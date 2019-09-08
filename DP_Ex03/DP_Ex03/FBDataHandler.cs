using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DP_Ex03
{
    public class FBDataHandler
    {
        private static readonly object sr_InstanceLock = new object();
        private static volatile FBDataHandler s_Instance;

        public static FBDataHandler Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FBDataHandler();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private readonly string r_AppID = "1450160541956417";
        private readonly string[] r_Permissions =
        {
            "public_profile",
            "email",
            "publish_to_groups",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "publish_to_groups",
            "groups_access_member_info",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown"
        };

        public delegate void AfterLoginToFacebook();

        public LoginResult LoginResult { get; private set; }
        public User LoggedInUser { get; private set; }
        public MostLikedFeature MostLikedFeature { get; private set; }
        public WordUsageStatistics WordUsageStatistics { get; private set; }
        public AppSettings AppSettings { get; private set; }
        public List<IPostExtender> ExtendedPosts { get; private set; }

        private FBDataHandler()
        {
        }

        public void LoginToFacebookAndInitUserData(PostLoginStrategy i_PostLoginStrategy)
        {
            LoginResult = FacebookService.Login(r_AppID, r_Permissions);
            initUserData();
            i_PostLoginStrategy.CallFunction(LoginResult);
        }

        public bool isExsitingAccessToken()
        {
            return AppSettings.RememberUser && !string.IsNullOrEmpty(AppSettings.LastAccessToken);
        }

        public void ConnectToFacebookIfThereIsAnAccessTokenAndInitUserData(PostLoginStrategy i_PostLoginStrategy)
        {
            if (isExsitingAccessToken())
            {
                try
                {
                    LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
                    initUserData();
                    i_PostLoginStrategy.CallFunction(LoginResult);
                }
                catch (Facebook.WebExceptionWrapper exception)
                {
                    throw exception;
                }
            }
        }

        private void initUserData()
        {
            LoggedInUser = LoginResult.LoggedInUser;
            MostLikedFeature = FeatureFactory.CreateFeature(FeatureFactory.eFeatures.MostLiked) as MostLikedFeature;
            MostLikedFeature.User = LoggedInUser;
            WordUsageStatistics = FeatureFactory.CreateFeature(FeatureFactory.eFeatures.WordUsageStatistics) as WordUsageStatistics;
            WordUsageStatistics.User = LoggedInUser;
            updateExtenededPosts();
        }

        public void LogoutFromFacebook(PostLogoutStrategy i_PostLogoutStrategy)
        {
            FacebookService.Logout(() =>
            {
                LoggedInUser = null;
                LoginResult = null;
                WordUsageStatistics = null;
                MostLikedFeature = null;
                i_PostLogoutStrategy.CallFunction();
            });
        }

        public void LoadAppSettingsFromFile()
        {
            AppSettings = AppSettings.LoadFromFile();
        }

        public void SaveAppSettingsToFile(Size i_WindowsSize, Point i_WindowLocation, bool i_RememberUser)
        {
            AppSettings.LastWindowSize = i_WindowsSize;
            AppSettings.LastWindowLocation = i_WindowLocation;
            AppSettings.RememberUser = i_RememberUser;
            if (LoginResult != null && i_RememberUser)
            {
                AppSettings.LastAccessToken = LoginResult.AccessToken;
            }
            else
            {
                AppSettings.LastAccessToken = null;
            }

            AppSettings.SaveToFile();
        }

        private void updateExtenededPosts()
        {
            ExtendedPosts = new List<IPostExtender>();
            foreach(Post post in LoggedInUser.Posts)
            {
                ExtendedPosts.Add(new PostExtenderFavorite(new PostExtenderNote(new CoreExtendedPost() { Post = post })));
            }
        }
    }
}
