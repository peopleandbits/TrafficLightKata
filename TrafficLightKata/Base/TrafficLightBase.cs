using System.Collections.Generic;
using TrafficLightKata.Infra;

namespace TrafficLightKata.Base
{
    public abstract class TrafficLightBase : ITrafficLight
    {
        public TrafficLightBase(IStateLogic logic, StatePackage sp = null)
        {
            Init(logic, sp);
        }

        #region Properties
        public LightState Current { get { return _State.Current; } }
        #endregion

        #region Fields
        Dictionary<LightState, ITrafficLightStateHandler> _StateLogic;
        StatePackage _State; 
        #endregion

        #region Public API
        public void GoNext()
        {
            _State = _StateLogic[Current].Handle(_State.Direction);
        }
        #endregion

        #region Private API
        void Init(IStateLogic logic, StatePackage sp)
        {
            _StateLogic = logic.GetLogic();

            if (sp == null)
                _State = new StatePackage(LightState.Red, StateDirection.TowardsGreen);
            else
                _State = sp;
        }
        #endregion
    }
}