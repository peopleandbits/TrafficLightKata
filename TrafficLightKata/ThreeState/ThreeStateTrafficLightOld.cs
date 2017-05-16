using TrafficLightKata.Infra;

namespace TrafficLightKata.ThreeState
{
    public class ThreeStateTrafficLightOld : ITrafficLight
    {
        #region Constructor
        public ThreeStateTrafficLightOld()
        {
            // init light to red state
            Current = LightState.Red;
            Prev = Next = LightState.Yellow;
        }
        #endregion

        #region Properties
        public LightState Current { get; private set; }
        #endregion

        #region Fields
        LightState Prev { get; set; }
        LightState Next { get; set; }
        #endregion

        #region Public API
        public void GoNext()
        {
            var prev = Current;

            switch (Current)
            {
                case LightState.Red:
                    Current = LightState.Yellow;
                    Next = LightState.Green;
                    break;

                case LightState.Yellow:
                    if (Prev == LightState.Red)
                    {
                        Current = LightState.Green;
                        Next = LightState.Yellow;
                    }
                    else
                    {
                        Current = LightState.Red;
                        Next = LightState.Yellow;
                    }
                    break;

                case LightState.Green:
                    Current = LightState.Yellow;
                    Next = LightState.Red;
                    break;

                default:
                    break;
            }

            Prev = prev;
        }
        #endregion
    }
}
