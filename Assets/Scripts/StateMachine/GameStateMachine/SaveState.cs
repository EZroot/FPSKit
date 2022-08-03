using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPSKit
{
    public class SaveState : State<GameStateMachine>
    {
        public override void OnEnter()
        {
            GlobalData.Instance.SaveGameBool = false;

            Debug.Log("SaveState entered");
        }

        public override void OnExit()
        {
            Debug.Log("SaveState exit");
        }

        public override void OnUpdate()
        {

        }
    }
}