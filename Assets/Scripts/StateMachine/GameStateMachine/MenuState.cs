using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    public class MenuState : State<GameStateMachine>
    {
        public override void OnEnter()
        {
            BaseFeature.View.ShowView();
            Debug.Log("menu state entered");
        }

        public override void OnExit()
        {
            BaseFeature.View.HideView();
            Debug.Log("menu state  exit");
        }

        public override void OnUpdate()
        {

        }
    }
}