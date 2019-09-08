using FacebookWrapper;
using System;

namespace DP_Ex03
{
    public class PostLogoutStrategy
    {
        public Action FunctionToCall { get; set; }

        public PostLogoutStrategy(Action i_Function)
        {
            FunctionToCall = i_Function;
        }

        public void CallFunction()
        {
            FunctionToCall();
        }
    }
}
