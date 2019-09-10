using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace DP_Ex03
{
    public class MostLikedFeature : IFeature
    {
        public User User { get; set; }
        public Dictionary<string, int> MostLikedFriends { get; }
        public List<FriendWhoLikesUser> FriendsWhoLikesUserMost { get; }

        private enum eLikeTypes
        {
            Posts,
            Comments,
        }

        private Dictionary<string, Dictionary<eLikeTypes, int>> m_FriendsWhoLikesUserFilter;

        public MostLikedFeature()
        {
            MostLikedFriends = new Dictionary<string, int>();
            FriendsWhoLikesUserMost = new List<FriendWhoLikesUser>();
        }

        public MostLikedFeature(User i_User)
        {
            User = i_User;
            MostLikedFriends = new Dictionary<string, int>();
            FriendsWhoLikesUserMost = new List<FriendWhoLikesUser>();
        }

        public void CalculateMostLikedFriends()
        {
            MostLikedFriends.Clear();
            foreach (User friend in User.Friends)
            {
                foreach (Post post in friend.Posts)
                {
                    foreach (User likedByUser in post.LikedBy)
                    {
                        incrementUserLikesByFriend(likedByUser);
                    }

                    foreach (Comment comment in post.Comments)
                    {
                        foreach (User likedByUser in comment.LikedBy)
                        {
                            incrementUserLikesByFriend(likedByUser);
                        }
                    }
                }
            }
        }

        public void CalculateFriendsWhoLikeUserMost()
        {
            FriendsWhoLikesUserMost.Clear();
            m_FriendsWhoLikesUserFilter = new Dictionary<string, Dictionary<eLikeTypes, int>>();
            foreach (Post post in User.Posts)
            {
                foreach (User likedByUser in post.LikedBy)
                {           
                    incrementFriendLikesByType(likedByUser, eLikeTypes.Posts);
                }

                foreach (Comment comment in post.Comments)
                {
                    foreach (User likedByUser in comment.LikedBy)
                    {
                        incrementFriendLikesByType(likedByUser, eLikeTypes.Comments);
                    }
                }
            }

            populateFriendsWhoLikesUserMost();
        }

        private void populateFriendsWhoLikesUserMost()
        {
            foreach (KeyValuePair<string, Dictionary<eLikeTypes, int>> friend in m_FriendsWhoLikesUserFilter)
            {
                FriendsWhoLikesUserMost.Add(new FriendWhoLikesUser() { Name = friend.Key, LikedPosts = friend.Value[eLikeTypes.Posts], LikedComments = friend.Value[eLikeTypes.Comments] });
            }
        }

        private void incrementFriendLikesByType(User i_LikedByUser, eLikeTypes i_Type)
        {
            if (!m_FriendsWhoLikesUserFilter.ContainsKey(i_LikedByUser.Name))
            {
                m_FriendsWhoLikesUserFilter[i_LikedByUser.Name] = new Dictionary<eLikeTypes, int>();
                m_FriendsWhoLikesUserFilter[i_LikedByUser.Name][eLikeTypes.Posts] = 0;
                m_FriendsWhoLikesUserFilter[i_LikedByUser.Name][eLikeTypes.Comments] = 0;
            }

            m_FriendsWhoLikesUserFilter[i_LikedByUser.Name][i_Type] = m_FriendsWhoLikesUserFilter[i_LikedByUser.Name][i_Type] + 1;
        }

        private void incrementUserLikesByFriend(User i_LikedByUser)
        {
            if (MostLikedFriends.ContainsKey(i_LikedByUser.Name))
            {
                MostLikedFriends[i_LikedByUser.Name] = MostLikedFriends[i_LikedByUser.Name] + 1;
            }
            else
            {
                MostLikedFriends[i_LikedByUser.Name] = 1;
            }
        }

        public class FriendWhoLikesUser
        {
            public string Name { get; set; }
            public int LikedPosts { get; set; }
            public int LikedComments { get; set; }
        }
    }
}
