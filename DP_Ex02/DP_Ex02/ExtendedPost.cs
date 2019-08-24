using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DP_Ex02
{
    public class ExtendedPost
    {
        public Post Post { get; set; }
        public string Note { get; set; }
        public bool Favorite { get; set; }
    }
}
