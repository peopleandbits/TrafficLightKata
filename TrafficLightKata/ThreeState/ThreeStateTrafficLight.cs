using System.Collections.Generic;

namespace TrafficLightTemplate.ThreeState
{
    public class ThreeStateTrafficLight : TrafficLightBase<ThreeStateProcess, ThreeStateLights>
    {
        public ThreeStateTrafficLight()
        {
            Current = ThreeStateLights.Red;

            StateHandling = new Dictionary<ThreeStateProcess, IStateHandler<ThreeStateProcess, ThreeStateLights>>()
            {
                {ThreeStateProcess.Red, new RedHandler()},
                {ThreeStateProcess.YellowGoingGreen, new YellowGoingGreenHandler()},
                {ThreeStateProcess.Green, new GreenHandler()},
                {ThreeStateProcess.YellowGoingRed, new YellowGoingRedHandler()},
            };
        }
    }
}