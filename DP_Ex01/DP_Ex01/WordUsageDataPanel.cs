using System.Collections.Generic;
using System.Windows.Forms;

namespace DP_Ex01
{
    public class WordUsageDataPanel : Panel
    {
        List<string> m_Posts;

        public List<string> Posts
        {
            get
            {
                return m_Posts;
            }
            set
            {
                m_Posts = value;
            }
        }
    }
}
