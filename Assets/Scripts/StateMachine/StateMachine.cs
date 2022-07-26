using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPSKit
{
    [System.Serializable]
    public struct TransitionState<T> where T : StateMachine<T>
    {
        public State<T> state;
        public List<TransitionCondition<T>> transitionConditions;
    }

    [System.Serializable]
    public struct TransitionCondition<T> where T : StateMachine<T>
    {
        public State<T> transitionToState;
        public StateCondition<T> condition;
        public bool _ifConditionStatus;
    }

    public class StateMachine<T> : MonoBehaviour where T : StateMachine<T>
    {
        public State<T> StartState;
        State<T> _currentState = null;
        public State<T> CurrentState { get => _currentState; set => _currentState = value; }
        public List<TransitionState<T>> CoreStates = new List<TransitionState<T>>();


        public void InitalizeStates(GameController controller)
        {
            //need to init game controller
            foreach (TransitionState<T> t in CoreStates)
            {
                t.state.BaseFeature = controller;
            }

            CurrentState = StartState;
            CurrentState.OnEnter();
        }

        void LateUpdate()
        {
            foreach (TransitionState<T> transition in CoreStates)
            {
                //make sure its the current transition
                if (transition.state.Equals(CurrentState))
                {
                    //for each transition condition
                    foreach (TransitionCondition<T> condition in transition.transitionConditions)
                    {
                        bool result = condition.condition.OnCondition(CurrentState, condition.transitionToState);
                        if (result == condition._ifConditionStatus)
                        {
                            SetState(condition.transitionToState);
                        }
                    }
                }
            }

            if (CurrentState != null)
            {
                CurrentState.OnUpdate();
            }
        }

        void SetState(State<T> newState)
        {
            CurrentState.OnExit();
            CurrentState = newState;
            newState.OnEnter();
        }
    }
}