using TrafficLightKata.Base;
using TrafficLightKata.FourState;
using TrafficLightKata.Infra;

namespace TrafficLightKata
{
    public class FourStateTrafficLight : TrafficLightBase
    {
        public FourStateTrafficLight(StatePackage sp = null) : base(new FourStateLogic(), sp) { }
    }
}