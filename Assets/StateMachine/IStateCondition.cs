namespace FPSKit
{
    public interface IStateCondition<T> where T : StateMachine<T>
    {
        abstract bool OnCondition(State<T> curr, State<T> next);
    }

}