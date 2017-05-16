using TrafficLightKata.Base;
using TrafficLightKata.Infra;
using TrafficLightKata.ThreeState;

namespace TrafficLightKata
{
    public class ThreeStateTrafficLight : TrafficLightBase
    {
        public ThreeStateTrafficLight(StatePackage sp = null) : base(new ThreeStateLogic(), sp) { }
    }
}