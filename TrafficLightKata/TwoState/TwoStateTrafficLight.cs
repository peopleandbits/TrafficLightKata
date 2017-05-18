using System;
using System.Collections.Generic;

namespace TrafficLightTemplate.FourState
{
    public class TwoStateTrafficLight : ITrafficLight<TwoStateLights>
    {
        public TwoStateTrafficLight()
        {
            Current = TwoStateLights.Red;

            _StateHandling = new Dictionary<TwoStateLights, TwoStateLights>()
            {
                {TwoStateLights.Red, TwoStateLights.Green},
                {TwoStateLights.Green, TwoStateLights.Red}                
            };
        }

        public TwoStateLights Current { get; set; }
        Dictionary<TwoStateLights, TwoStateLights> _StateHandling;

        public void GoNext()
        {
            Current = _StateHandling[Current];
        }
    }
}
