using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static DP_Ex03.MostLikedFeature;

namespace DP_Ex03
{
    public class FriendsWhoLikesUserViewer : MostLikedFeatureViewer
    {
        private BindingSource m_BindingSource;

        public FriendsWhoLikesUserViewer(DataGridView i_GridView, Button i_FetchButton, MostLikedFeature i_MostLikedFeatureObject) : base(i_GridView, i_FetchButton, i_MostLikedFeatureObject)
        {
            m_BindingSource = new BindingSource();
        }

        protected override IList CreateDataSource()
        {
            MostLikedFeatureObject.CalculateFriendsWhoLikeUserMost();

            // Sort in descending order by total number of liked posts AND comments
            MostLikedFeatureObject.FriendsWhoLikesUserMost.Sort((friend1, friend2) => 
                (friend2.LikedPosts + friend2.LikedComments).CompareTo(friend1.LikedPosts + friend1.LikedComments)
            );
            return MostLikedFeatureObject.FriendsWhoLikesUserMost;
        }

        protected override void PopulateGridViewDataSource(IList i_DataStructure)
        {
            GridView.DataSource = m_BindingSource;
            m_BindingSource.DataSource = i_DataStructure;
            GridView.Columns[0].HeaderText = "Friend";
            GridView.Columns[1].HeaderText = "Posts Likes";
            GridView.Columns[2].HeaderText = "Comments Likes";
        }
    }
}
