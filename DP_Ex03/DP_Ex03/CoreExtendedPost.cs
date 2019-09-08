using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP_Ex03
{
    public class CoreExtendedPost : IPostExtender
    {
        public Post Post { get; set; }

        public void updateDataToServer()
        {
            // Here will be code to update new data to the server
        }
    }
}
