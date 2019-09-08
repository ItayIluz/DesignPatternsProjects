using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Ex03
{
    public class PostExtenderNote : PostExtender
    {
        public string Note { get; set; }
        public PostExtenderNote(IPostExtender i_PostExtender) : base(i_PostExtender)
        {
            Note = string.Empty;
        }

        public override void updateDataToServer()
        {
            ExtraPostExtender.updateDataToServer();
            // Here will be extra code to update the post's note data
        }

        // Add more "Note" feature methods
    }
}
