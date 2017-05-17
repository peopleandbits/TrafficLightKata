using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightKata.Infra;

namespace TrafficLightKata.Tests
{
    [TestClass]
    public class NaiveThreeStateTrafficLightTest
    {
        [TestMethod]
        public void Run3StatesNaive()
        {
            var tl = new NaiveThreeStateTrafficLight();
            var states = new[] { LightState.Red, LightState.Yellow, LightState.Green, LightState.Yellow, LightState.Red };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }
    }
}