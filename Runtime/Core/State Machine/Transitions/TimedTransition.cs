using UnityEngine;
using System;

namespace Popieyes.AI.Transitions
{
    public class TimedTransition : Transition
    {
        private float duration;
        private float timer;

        public TimedTransition(Type targetState, float duration) : base(targetState, null)
        {
            this.duration = duration;
            this.timer = 0f;
            this.Condition = CheckCondition;
        }

        private bool CheckCondition()
        {
            timer += Time.deltaTime;
            if (timer >= duration)
            {
                timer = 0f; // Reset timer for next use
                return true;
            }
            return false;
        }
    }
}
