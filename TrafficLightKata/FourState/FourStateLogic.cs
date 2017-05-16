using System.Collections.Generic;
using TrafficLightKata.Infra;

namespace TrafficLightKata.FourState
{
    public class FourStateLogic : IStateLogic
    {
        public Dictionary<LightState, ITrafficLightStateHandler> GetLogic()
        {
            return new Dictionary<LightState, ITrafficLightStateHandler>()
            {
                {LightState.Red, new RedToRedYellowChangeHandler()},
                {LightState.RedYellow, new RedYellowToGreenChangeHandler()},
                {LightState.Green, new GreenToYellowChangeHandler()},
                {LightState.Yellow, new YellowToRedChangeHandler()}
            };
        }
    }
}