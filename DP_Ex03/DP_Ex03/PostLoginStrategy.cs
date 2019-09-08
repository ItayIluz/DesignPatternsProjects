using FacebookWrapper;
using System;

namespace DP_Ex03
{
    public class PostLoginStrategy
    {
        public Action<LoginResult> FunctionToCall { get; set; }

        public PostLoginStrategy(Action<LoginResult> i_Function)
        {
            FunctionToCall = i_Function;
        }

        public void CallFunction(LoginResult i_LoginResult)
        {
            FunctionToCall(i_LoginResult);
        }
    }
}
