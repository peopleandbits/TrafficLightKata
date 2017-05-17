namespace TrafficLightTemplate
{
    public interface ITrafficLight<L>
    {
        L Current { get; }
        void GoNext();
    }

    public interface IStateHandler<P, L>
    {
        P GetNextProcessState();
        L GetLightState();
    }
}