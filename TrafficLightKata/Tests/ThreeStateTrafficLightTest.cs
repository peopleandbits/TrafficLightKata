using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightKata.Infra;

namespace TrafficLightKata.Tests
{
    [TestClass]
    public class ThreeStateTrafficLightTest
    {
        [TestMethod]
        public void Run3States()
        {
            var tl = new ThreeStateTrafficLight();
            var states = new[] { LightState.Red, LightState.Yellow, LightState.Green, LightState.Yellow, LightState.Red };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }
    }
}