using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPSKit
{
    public class State<T> : MonoBehaviour, IState where T : StateMachine<T>
    {

        public virtual void OnEnter()
        {

        }

        public virtual void OnUpdate()
        {
        }

        public virtual void OnExit()
        {

        }
    }
}