using TrafficLightKata.Infra;

namespace TrafficLightKata.ThreeState
{
    public class RedToYellowChangeHandler : ITrafficLightStateHandler
    {
        public StatePackage Handle(StateDirection dir)
        {
            return new StatePackage(LightState.Yellow, StateDirection.TowardsGreen);
        }
    }

    public class YellowToRedOrGreenChangeHandler : ITrafficLightStateHandler
    {
        public StatePackage Handle(StateDirection dir)
        {
            return new StatePackage(dir == StateDirection.TowardsGreen ? LightState.Green : LightState.Red, dir);
        }
    }

    public class GreenToYellowChangeHandler : ITrafficLightStateHandler
    {
        public StatePackage Handle(StateDirection dir)
        {
            return new StatePackage(LightState.Yellow, StateDirection.TowardsRed);
        }
    }
}