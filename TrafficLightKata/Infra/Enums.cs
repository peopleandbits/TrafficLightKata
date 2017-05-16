namespace TrafficLightKata.Infra
{
    // shared between ThreeStateTrafficLight and FourStateTrafficLight
    public enum LightState { Red, RedYellow, Yellow, Green } 

    public enum StateDirection { TowardsRed, TowardsGreen };
}