using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPSKit
{
    public class PlayState : State<GameStateMachine>
    {
        public override void OnEnter()
        {
            Debug.Log("Playing game state entered");
        }

        public override void OnExit()
        {
            Debug.Log("Playing game state exit");
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GlobalData.Instance.ShowMenuBool = true;
            }
        }
    }
}