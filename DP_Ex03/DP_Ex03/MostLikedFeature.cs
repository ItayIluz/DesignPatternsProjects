using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace DP_Ex03
{
    public class MostLikedFeature : IFeature
    {
        public User User { get; set; }
        public Dictionary<string, int> MostLikedFriends { get; }
        public Dictionary<string, int> FriendsWhoLikesUserMost { get; }

        public MostLikedFeature()
        {
            MostLikedFriends = new Dictionary<string, int>();
            FriendsWhoLikesUserMost = new Dictionary<string, int>();
        }

        public MostLikedFeature(User i_User)
        {
            User = i_User;
            MostLikedFriends = new Dictionary<string, int>();
            FriendsWhoLikesUserMost = new Dictionary<string, int>();
        }

        public void CalculateMostLikedFriends()
        {
            MostLikedFriends.Clear();
            foreach (User friend in User.Friends)
            {
                calculateMostLikedItemsForUser(MostLikedFriends, friend);
            }
        }

        public void CalculateFriendsWhoLikeUserMost()
        {
            FriendsWhoLikesUserMost.Clear();
            calculateMostLikedItemsForUser(FriendsWhoLikesUserMost, User);
        }

        private void calculateMostLikedItemsForUser(Dictionary<string, int> i_Results, User i_User)
        {
            foreach (Post post in i_User.Posts)
            {
                foreach (User likedByUser in post.LikedBy)
                {
                    incrementFriendLikes(i_Results, likedByUser);
                }

                foreach (Comment comment in post.Comments)
                {
                    foreach (User likedByUser in comment.LikedBy)
                    {
                        incrementFriendLikes(i_Results, likedByUser);
                    }
                }
            }
        }

        private void incrementFriendLikes(Dictionary<string, int> i_DataStructure, User i_LikedByUser)
        {
            if (i_DataStructure.ContainsKey(i_LikedByUser.Name))
            {
                i_DataStructure[i_LikedByUser.Name] = i_DataStructure[i_LikedByUser.Name] + 1;
            }
            else
            {       
                i_DataStructure[i_LikedByUser.Name] = 1;
            }
        }
    }
}
