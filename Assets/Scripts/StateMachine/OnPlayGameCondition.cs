using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public class OnPlayGameCondition : StateCondition<GameStateMachine>
    {
        public override bool OnCondition(State<GameStateMachine> curr, State<GameStateMachine> next)
        {
            if (GlobalData.Instance.PlayGame)
            {
                GlobalData.Instance.PlayGame = false;
                return true;
            }
            return GlobalData.Instance.PlayGame;
        }
    }
}