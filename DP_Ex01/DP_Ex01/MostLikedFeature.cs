using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace DP_Ex01
{
    public class MostLikedFeature
    {
        private User m_User = null;
        private Dictionary<User, Dictionary<eLikedItem, int>> m_MostLikedFriends;
        private Dictionary<User, Dictionary<eLikedItem, int>> m_WhoLikesUserMost;

        public enum eLikedItem
        {
            Post,
            Comment
        }

        public MostLikedFeature(User i_User)
        {
            m_User = i_User;
            m_MostLikedFriends = new Dictionary<User, Dictionary<eLikedItem, int>>();
            m_WhoLikesUserMost = new Dictionary<User, Dictionary<eLikedItem, int>>();
        }

        public void CalculateMostLikedFriends()
        {
            foreach (User friend in m_User.Friends)
            {
                calculateMostLikedItemsForUser(m_MostLikedFriends, friend);
            }
        }

        public void CalculateWhoLikesUserMost()
        {
            calculateMostLikedItemsForUser(m_WhoLikesUserMost, m_User);
        }

        private void calculateMostLikedItemsForUser(Dictionary<User, Dictionary<eLikedItem, int>> i_Results, User i_User)
        {
            foreach (Post post in i_User.Posts)
            {
                foreach (User likedByUser in post.LikedBy)
                {
                    incrementLikedItem(i_Results, likedByUser, eLikedItem.Post);
                }

                foreach (Comment comment in post.Comments)
                {
                    foreach (User likedByUser in comment.LikedBy)
                    {
                        incrementLikedItem(i_Results, likedByUser, eLikedItem.Comment);
                    }
                }
            }
        }

        private void incrementLikedItem(Dictionary<User, Dictionary<eLikedItem, int>> i_DataStructure, User i_LikedByUser, eLikedItem i_LikedItem)
        {
            if (i_DataStructure.ContainsKey(i_LikedByUser))
            {
                if (i_DataStructure[i_LikedByUser].ContainsKey(i_LikedItem))
                {
                    i_DataStructure[i_LikedByUser][i_LikedItem]++;
                }
                else
                {
                    i_DataStructure[i_LikedByUser][i_LikedItem] = 1;
                }
            }
            else
            {
                Dictionary<eLikedItem, int> likedItems = new Dictionary<eLikedItem, int>();
                likedItems[i_LikedItem] = 1;
                i_DataStructure[i_LikedByUser] = likedItems;
            }
        }
    }
}
