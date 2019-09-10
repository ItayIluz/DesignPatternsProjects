using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DP_Ex03
{
    public class MostLikedFriendsViewer : MostLikedFeatureViewer
    {
        public MostLikedFriendsViewer(DataGridView i_GridView, Button i_FetchButton, MostLikedFeature i_MostLikedFeatureObject) : base(i_GridView, i_FetchButton, i_MostLikedFeatureObject)
        {
        }

        protected override IList CreateDataSource()
        {
            MostLikedFeatureObject.CalculateMostLikedFriends();
            List<KeyValuePair<string, int>> sortedResultList = MostLikedFeatureObject.MostLikedFriends.ToList();
            sortedResultList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            return sortedResultList;
        }

        protected override void PopulateGridViewDataSource(IList i_DataStructure)
        {
            GridView.DataSource = i_DataStructure;
            GridView.Columns[0].HeaderText = "Friend";
            GridView.Columns[1].HeaderText = "Total Likes";
        }
    }
}
