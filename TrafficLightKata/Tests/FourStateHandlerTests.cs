using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightKata.Infra;
using TrafficLightKata.FourState;

namespace TrafficLightKata.Tests
{
    [TestClass]
    public class FourStateHandlerTests
    {
        [TestMethod]
        public void RedToRedYellowChangeHandler()
        {
            var handler = new RedToRedYellowChangeHandler();
            var sp = handler.Handle(StateDirection.TowardsGreen);

            Assert.AreEqual(LightState.RedYellow, sp.Current);
            Assert.AreEqual(StateDirection.TowardsGreen, sp.Direction);
        }

        [TestMethod]
        public void RedYellowToGreenChangeHandler()
        {
            var handler = new RedYellowToGreenChangeHandler();
            var sp = handler.Handle(StateDirection.TowardsGreen);

            Assert.AreEqual(LightState.Green, sp.Current);
            Assert.AreEqual(StateDirection.TowardsGreen, sp.Direction);
        }

        [TestMethod]
        public void GreenToYellowChangeHandler()
        {
            var handler = new GreenToYellowChangeHandler();
            var sp = handler.Handle(StateDirection.TowardsGreen);

            Assert.AreEqual(LightState.Yellow, sp.Current);
            Assert.AreEqual(StateDirection.TowardsRed, sp.Direction);
        }

        [TestMethod]
        public void YellowToRedChangeHandler()
        {
            var handler = new YellowToRedChangeHandler();
            var sp = handler.Handle(StateDirection.TowardsGreen);

            Assert.AreEqual(LightState.Red, sp.Current);
            Assert.AreEqual(StateDirection.TowardsRed, sp.Direction);
        }
    }
}