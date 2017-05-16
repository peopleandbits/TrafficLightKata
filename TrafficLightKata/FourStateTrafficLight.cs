using TrafficLightKata.Base;
using TrafficLightKata.FourState;
using TrafficLightKata.Infra;

namespace TrafficLightKata
{
    /// <summary>
    /// Needs a comment...
    /// </summary>
    public class FourStateTrafficLight : TrafficLightBase
    {
        public FourStateTrafficLight(StatePackage sp = null) : base(new FourStateLogic(), sp) { }
    }
}