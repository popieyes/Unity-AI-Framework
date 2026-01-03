using System.Collections.Generic;
using UnityEngine;
using Popieyes.AI.Transitions;

namespace Popieyes.AI
{
    public abstract class StateBase : MonoBehaviour
    {
        public List<Transition> Transitions { get; } = new List<Transition>();
        public abstract void SetupTransitions();
        public virtual void OnAwake(){}
        public abstract void OnEnter();
        public abstract void OnExit();
        public abstract void OnStep();
        public abstract void OnFixedStep();
        public virtual void TriggerEnter(Collider other){}
        public virtual void TriggerExit(Collider other){}
        public virtual void TriggerStay(Collider other){}
        public virtual void CollisionEnter(Collision collision){}
        public virtual void CollisionExit(Collision collision){}
        public virtual void CollisionStay(Collision collision){}
    }
    public abstract class State<TContext> : StateBase
    {
        protected TContext context;
        public void SetContext(TContext context) => this.context = context;

    }
}
