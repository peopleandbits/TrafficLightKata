namespace TrafficLightTemplate.ThreeState
{
    public class RedHandler : IStateHandler<ThreeStateProcess, ThreeStateLights>
    {
        public ThreeStateProcess GetNextProcessState()
        {
            return ThreeStateProcess.YellowGoingGreen;
        }

        public ThreeStateLights GetLightState()
        {
            return ThreeStateLights.Yellow;
        }
    }

    public class YellowGoingGreenHandler : IStateHandler<ThreeStateProcess, ThreeStateLights>
    {
        public ThreeStateProcess GetNextProcessState()
        {
            return ThreeStateProcess.Green;
        }

        public ThreeStateLights GetLightState()
        {
            return ThreeStateLights.Green;
        }
    }

    public class GreenHandler : IStateHandler<ThreeStateProcess, ThreeStateLights>
    {
        public ThreeStateProcess GetNextProcessState()
        {
            return ThreeStateProcess.YellowGoingRed;
        }

        public ThreeStateLights GetLightState()
        {
            return ThreeStateLights.Yellow;
        }
    }

    public class YellowGoingRedHandler : IStateHandler<ThreeStateProcess, ThreeStateLights>
    {
        public ThreeStateProcess GetNextProcessState()
        {
            return ThreeStateProcess.Red;
        }

        public ThreeStateLights GetLightState()
        {
            return ThreeStateLights.Red;
        }
    }
}