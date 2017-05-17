using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightKata.ThreeState;
using TrafficLightKata.Infra;

namespace TrafficLightKata.Tests
{
    [TestClass]
    public class ThreeStateHandlerTests
    {
        [TestMethod]
        public void RedToYellowChangeHandler()
        {
            var handler = new RedToYellowChangeHandler();
            var sp = handler.Handle(StateDirection.TowardsGreen);

            Assert.AreEqual(LightState.Yellow, sp.Current);
            Assert.AreEqual(StateDirection.TowardsGreen, sp.Direction);
        }

        [TestMethod]
        public void YellowToRedOrGreenChangeHandler()
        {
            var handler = new YellowToRedOrGreenChangeHandler();
            var sp = handler.Handle(StateDirection.TowardsGreen); // going towards green

            Assert.AreEqual(LightState.Green, sp.Current);
            Assert.AreEqual(StateDirection.TowardsGreen, sp.Direction);

            sp = handler.Handle(StateDirection.TowardsRed); // going towards red

            Assert.AreEqual(LightState.Red, sp.Current);
            Assert.AreEqual(StateDirection.TowardsRed, sp.Direction);
        }

        [TestMethod]
        public void GreenToYellowChangeHandler()
        {
            var handler = new GreenToYellowChangeHandler();
            var sp = handler.Handle(StateDirection.TowardsGreen);

            Assert.AreEqual(LightState.Yellow, sp.Current);
            Assert.AreEqual(StateDirection.TowardsRed, sp.Direction);
        }
    }
}