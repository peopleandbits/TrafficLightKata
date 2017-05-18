using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightTemplate.FourState;
using TrafficLightTemplate.ThreeState;

namespace TrafficLightTemplate
{
    [TestClass]
    public class TrafficLightTests
    {
        [TestMethod]
        public void TwoStateTrafficLightTest()
        {
            var tl = new TwoStateTrafficLight();
            var states = new[]
            {
                TwoStateLights.Red, TwoStateLights.Green,
                TwoStateLights.Red, TwoStateLights.Green
            };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }

        [TestMethod]
        public void NaiveThreeStateTrafficLight()
        {
            var tl = new NaiveThreeStateTrafficLight();
            var states = new[]
            {
                ThreeStateLights.Red, ThreeStateLights.Yellow, ThreeStateLights.Green, ThreeStateLights.Yellow,
                ThreeStateLights.Red, ThreeStateLights.Yellow, ThreeStateLights.Green, ThreeStateLights.Yellow
            };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }

        [TestMethod]
        public void ThreeStateTrafficLightTest()
        {
            var tl = new ThreeStateTrafficLight();
            var states = new[] 
            {
                ThreeStateLights.Red, ThreeStateLights.Yellow, ThreeStateLights.Green, ThreeStateLights.Yellow,
                ThreeStateLights.Red, ThreeStateLights.Yellow, ThreeStateLights.Green, ThreeStateLights.Yellow
            };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }

        [TestMethod]
        public void NaiveFourStateTrafficLightTest()
        {
            var tl = new NaiveFourStateTrafficLight();
            var states = new[] 
            {
                FourStateLights.Red, FourStateLights.RedYellow, FourStateLights.Green, FourStateLights.Yellow,
                FourStateLights.Red, FourStateLights.RedYellow, FourStateLights.Green, FourStateLights.Yellow
            };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }

        [TestMethod]
        public void FourStateTrafficLightTest()
        {
            var tl = new FourStateTrafficLight();
            var states = new[]
            {
                FourStateLights.Red, FourStateLights.RedYellow, FourStateLights.Green, FourStateLights.Yellow,
                FourStateLights.Red, FourStateLights.RedYellow, FourStateLights.Green, FourStateLights.Yellow
            };

            foreach (var state in states)
            {
                Assert.AreEqual(state, tl.Current);
                tl.GoNext();
            }
        }
    }
}