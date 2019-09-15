using System;
using FacebookWrapper;

namespace DP_Ex03
{
    public class AfterLoginStrategy
    {
        public Action<LoginResult> FunctionToCall { get; set; }

        public AfterLoginStrategy(Action<LoginResult> i_Function)
        {
            FunctionToCall = i_Function;
        }

        public void CallFunction(LoginResult i_LoginResult)
        {
            FunctionToCall(i_LoginResult);
        }
    }
}
