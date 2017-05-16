using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightKata.Infra;

namespace TrafficLightKata.Tests
{
    [TestClass]
    public class FourStateTrafficLightTest
    {
        [TestMethod]
        public void Run4States()
        {
            var tl = new FourStateTrafficLight();
            var states = new[] { LightState.Red, LightState.RedYellow, LightState.Green, LightState.Yellow, LightState.Red };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }
    }
}