using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public class OnLoadCondition : StateCondition<GameStateMachine>
    {
        public override bool OnCondition(State<GameStateMachine> curr, State<GameStateMachine> next)
        {
            return GlobalData.Instance.LoadGameBool;
        }

    }
}