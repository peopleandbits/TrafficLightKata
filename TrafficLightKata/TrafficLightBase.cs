using System.Collections.Generic;

namespace TrafficLightTemplate
{
    public abstract class TrafficLightBase<P, L> : ITrafficLight<L>
    {
        public L Current { get; set; }
        protected Dictionary<P, IStateHandler<P, L>> StateHandling;
        P _ProcessState { get; set; }

        public void GoNext()
        {
            Current = StateHandling[_ProcessState].GetLightState();
            _ProcessState = StateHandling[_ProcessState].GetNextProcessState();
        }
    }
}
