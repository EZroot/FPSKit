using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public class EndState : State<GameStateMachine>
    {
        public override void OnEnter()
        {
            Debug.Log("EndState state entered");
        }

        public override void OnExit()
        {
            Debug.Log("EndState state exit");
        }

        public override void OnUpdate()
        {

        }
    }
}