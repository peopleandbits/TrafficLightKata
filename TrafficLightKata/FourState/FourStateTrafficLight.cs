using System.Collections.Generic;

namespace TrafficLightTemplate.FourState
{
    public class FourStateTrafficLight : TrafficLightBase<FourStateProcess, FourStateLights>
    {
        public FourStateTrafficLight()
        {
            Current = FourStateLights.Red;

            StateHandling = new Dictionary<FourStateProcess, IStateHandler<FourStateProcess, FourStateLights>>()
            {
                {FourStateProcess.Red, new RedHandler()},
                {FourStateProcess.RedYellow, new RedYellowHandler()},
                {FourStateProcess.Green, new GreenHandler()},
                {FourStateProcess.Yellow, new YellowHandler()}
            };
        }
    }
}
