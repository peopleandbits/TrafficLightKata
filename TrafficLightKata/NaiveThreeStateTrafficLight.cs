using TrafficLightKata.Infra;

namespace TrafficLightKata
{
    public class NaiveThreeStateTrafficLight : ITrafficLight
    {
        public NaiveThreeStateTrafficLight()
        {
            Current = LightState.Red;
            _GoingTowardsGreen = true;
        }

        public LightState Current { get; set; }
        bool _GoingTowardsGreen;

        public void GoNext()
        {
            switch (Current)
            {
                default:
                case LightState.Red: Current = LightState.Yellow; _GoingTowardsGreen = true; return;
                case LightState.Yellow: Current = _GoingTowardsGreen ? Current = LightState.Green : Current = LightState.Red; return;
                case LightState.Green: Current = LightState.Yellow; _GoingTowardsGreen = false; return;
            }
        }
    }
}