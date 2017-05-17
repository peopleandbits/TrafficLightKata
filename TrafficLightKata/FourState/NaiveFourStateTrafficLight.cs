namespace TrafficLightTemplate.FourState
{
    public class NaiveFourStateTrafficLight : ITrafficLight<FourStateLights>
    {
        public NaiveFourStateTrafficLight()
        {
            Current = FourStateLights.Red;
        }

        public FourStateLights Current { get; set; }

        public void GoNext()
        {
            switch (Current)
            {
                default:
                case FourStateLights.Red: Current = FourStateLights.RedYellow; return;
                case FourStateLights.RedYellow: Current = FourStateLights.Green; return;
                case FourStateLights.Green: Current = FourStateLights.Yellow; return;
                case FourStateLights.Yellow: Current = FourStateLights.Red; return;
            }
        }
    }
}