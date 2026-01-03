using System;

namespace Popieyes.AI.Transitions
{
    public class Transition
    {
        public Type TargetState { get; protected set; }
        public Func<bool> Condition { get; protected set; }
        public Transition(Type targetState, Func<bool> condition)   
        {
            TargetState = targetState;
            Condition = condition;
        }
    }
}