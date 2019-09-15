using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DP_Ex03
{
    public abstract class MostLikedFeatureViewer
    {
        public DataGridView GridView { get; private set; }
        public Button FetchButton { get; private set; }
        public MostLikedFeature MostLikedFeatureObject { get; set; }

        public MostLikedFeatureViewer(DataGridView i_GridView, Button i_FetchButton, MostLikedFeature i_MostLikedFeatureObject)
        {
            GridView = i_GridView;
            FetchButton = i_FetchButton;
            MostLikedFeatureObject = i_MostLikedFeatureObject;
        }

        public void PopulateGridView()
        {
            if (FetchButton.InvokeRequired)
            {
                FetchButton.Invoke(new Action(() =>
                {
                    FetchButton.Text = "Fetching...";
                    FetchButton.Enabled = false;
                }));
            }

            IList dataSource = CreateDataSource();
            if (dataSource.Count != 0)
            {
                if (GridView.InvokeRequired)
                {
                    GridView.Invoke(new Action(() => PopulateGridViewDataSource(dataSource)));
                }
            }
            else
            {
                MessageBox.Show("No data found :(");
            }

            if (FetchButton.InvokeRequired)
            {
                FetchButton.Invoke(new Action(() =>
                {
                    FetchButton.Enabled = true;
                    FetchButton.Text = "Fetch";
                }));
            }
        }

        protected abstract IList CreateDataSource();

        protected abstract void PopulateGridViewDataSource(IList i_DataStructure);
    }
}
