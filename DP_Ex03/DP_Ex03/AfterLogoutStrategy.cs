using System;

namespace DP_Ex03
{
    public class AfterLogoutStrategy
    {
        public Action FunctionToCall { get; set; }

        public AfterLogoutStrategy(Action i_Function)
        {
            FunctionToCall = i_Function;
        }

        public void CallFunction()
        {
            FunctionToCall();
        }
    }
}
