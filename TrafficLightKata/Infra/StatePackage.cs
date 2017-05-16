namespace TrafficLightKata.Infra
{
    public class StatePackage
    {
        public StatePackage(LightState current, StateDirection direction)
        {
            Current = current;
            Direction = direction;
        }

        public LightState Current { get; set; }
        public StateDirection Direction { get; set; }
    }
}