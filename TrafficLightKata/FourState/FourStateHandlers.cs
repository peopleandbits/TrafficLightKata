namespace TrafficLightTemplate.FourState
{
    public class RedHandler : IStateHandler<FourStateProcess, FourStateLights>
    {
        public FourStateProcess GetNextProcessState()
        {
            return FourStateProcess.RedYellow;
        }

        public FourStateLights GetLightState()
        {
            return FourStateLights.RedYellow;
        }
    }

    public class RedYellowHandler : IStateHandler<FourStateProcess, FourStateLights>
    {
        public FourStateProcess GetNextProcessState()
        {
            return FourStateProcess.Green;
        }

        public FourStateLights GetLightState()
        {
            return FourStateLights.Green;
        }
    }

    public class GreenHandler : IStateHandler<FourStateProcess, FourStateLights>
    {
        public FourStateProcess GetNextProcessState()
        {
            return FourStateProcess.Yellow;
        }

        public FourStateLights GetLightState()
        {
            return FourStateLights.Yellow;
        }
    }

    public class YellowHandler : IStateHandler<FourStateProcess, FourStateLights>
    {
        public FourStateProcess GetNextProcessState()
        {
            return FourStateProcess.Red;
        }

        public FourStateLights GetLightState()
        {
            return FourStateLights.Red;
        }
    }
}