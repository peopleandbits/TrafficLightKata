using System.Collections.Generic;
using TrafficLightKata.Infra;

namespace TrafficLightKata.ThreeState
{
    public class ThreeStateLogic : IStateLogic
    {
        public Dictionary<LightState, ITrafficLightStateHandler> GetLogic()
        {
            return new Dictionary<LightState, ITrafficLightStateHandler>()
            {
                {LightState.Red, new RedToYellowChangeHandler()},
                {LightState.Yellow, new YellowToRedOrGreenChangeHandler()},
                {LightState.Green, new GreenToYellowChangeHandler()},
            };
        }
    }
}