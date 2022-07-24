using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public class OnMenuCondition : StateCondition<GameStateMachine>
    {
        public override bool OnCondition(State<GameStateMachine> curr, State<GameStateMachine> next)
        {
            if (GlobalData.Instance.ShowMenuBool)
            {
                GlobalData.Instance.ShowMenuBool = false;
                return true;
            }
            return GlobalData.Instance.ShowMenuBool;
        }
    }
}