using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace DP_Ex02
{
    public class MostLikedFeature
    {
        private User m_User = null;
        public Dictionary<string, int> m_MostLikedFriends { get; }
        public Dictionary<string, int> m_FriendsWhoLikesUserMost { get; }

        public MostLikedFeature(User i_User)
        {
            m_User = i_User;
            m_MostLikedFriends = new Dictionary<string, int>();
            m_FriendsWhoLikesUserMost = new Dictionary<string, int>();
        }

        public void CalculateMostLikedFriends()
        {
            m_MostLikedFriends.Clear();
            foreach (User friend in m_User.Friends)
            {
                calculateMostLikedItemsForUser(m_MostLikedFriends, friend);
            }
        }

        public void CalculateFriendsWhoLikeUserMost()
        {
            m_FriendsWhoLikesUserMost.Clear();
            calculateMostLikedItemsForUser(m_FriendsWhoLikesUserMost, m_User);
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
