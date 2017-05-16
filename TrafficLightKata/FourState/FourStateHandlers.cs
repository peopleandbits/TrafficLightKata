using TrafficLightKata.Infra;

namespace TrafficLightKata.FourState
{
    public class RedToRedYellowChangeHandler : ITrafficLightStateHandler
    {
        public StatePackage Handle(StateDirection dir)
        {
            return new StatePackage(LightState.RedYellow, StateDirection.TowardsGreen);
        }
    }

    public class RedYellowToGreenChangeHandler : ITrafficLightStateHandler
    {
        public StatePackage Handle(StateDirection dir)
        {
            return new StatePackage(LightState.Green, StateDirection.TowardsGreen);
        }
    }

    public class GreenToYellowChangeHandler : ITrafficLightStateHandler
    {
        public StatePackage Handle(StateDirection dir)
        {
            return new StatePackage(LightState.Yellow, StateDirection.TowardsRed);
        }
    }

    public class YellowToRedChangeHandler : ITrafficLightStateHandler
    {
        public StatePackage Handle(StateDirection dir)
        {
            return new StatePackage(LightState.Red, StateDirection.TowardsRed);
        }
    }
}