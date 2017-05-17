namespace TrafficLightTemplate.ThreeState
{
    public class NaiveThreeStateTrafficLight : ITrafficLight<ThreeStateLights>
    {
        public NaiveThreeStateTrafficLight()
        {
            Current = ThreeStateLights.Red;
            _GoingTowardsGreen = true;
        }

        public ThreeStateLights Current { get; set; }
        bool _GoingTowardsGreen;

        public void GoNext()
        {
            switch (Current)
            {
                default:
                case ThreeStateLights.Red: Current = ThreeStateLights.Yellow; _GoingTowardsGreen = true; return;
                case ThreeStateLights.Yellow: Current = _GoingTowardsGreen ? ThreeStateLights.Green : ThreeStateLights.Red; return;
                case ThreeStateLights.Green: Current = ThreeStateLights.Yellow; _GoingTowardsGreen = false; return;
            }
        }
    }
}