using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public class LoadState : State<GameStateMachine>
    {
        public override void OnEnter()
        {
            Debug.Log("LoadState entered");
            GlobalData.Instance.LoadGameBool = false;
        }

        public override void OnExit()
        {
            Debug.Log("LoadState exit");
        }

        public override void OnUpdate()
        {

        }
    }
}