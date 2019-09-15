using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Ex03
{
    public class PostExtenderFavorite : PostExtender
    {
        public bool IsFavorite { get; set; }

        public PostExtenderFavorite(IPostExtender i_PostExtender) : base(i_PostExtender)
        {
            IsFavorite = false;
        }

        public override void UpdateDataToServer()
        {
            ExtraPostExtender.UpdateDataToServer();
            // Here will be extra code to update the post's favorite data
        }

        public void AddToTop10Favorites()
        {
            // Here will be extra data to update to the server 
        }

        // Add more "Favorite" feature methods
    }
}
