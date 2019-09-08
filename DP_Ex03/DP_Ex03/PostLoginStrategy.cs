using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Ex03
{
    public interface PostLoginStrategy
    {
        void AfterLoginToFacebook(LoginResult i_LoginResult);
    }
}
