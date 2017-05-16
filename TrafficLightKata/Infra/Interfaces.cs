using System.Collections.Generic;

namespace TrafficLightKata.Infra
{
    public interface ITrafficLight
    {
        LightState Current { get; }
        void GoNext();
    }

    public interface IStateLogic
    {
        Dictionary<LightState, ITrafficLightStateHandler> GetLogic();
    }

    public interface ITrafficLightStateHandler
    {
        StatePackage Handle(StateDirection dir);
    }
}