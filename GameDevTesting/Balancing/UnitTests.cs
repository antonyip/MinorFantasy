using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Balancing
{
    using Google2u;

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FirstHeroIsNoHero()
        {
            Assert.AreEqual(HeroesData.Instance.Rows[0]._Name, "No Hero");
        }

        [TestMethod]
        public void AllHeroStatsAreWithinLimits()
        {
            const int LowerLimit = 50;
            const int UpperLimit = 100;
            foreach (var Hero in HeroesData.Instance.Rows)
            {
                int TotalValue = Hero._STR + Hero._DEX + Hero._LUK + Hero._INT;
                bool TestPass = TestHelpers.ValueIsBetween(TotalValue, LowerLimit, UpperLimit);
                Assert.IsTrue(TestPass, Hero._Name + " failed!");
            }
        }

        [TestMethod]
        public void AllHerosShouldOneShotTheirLevel1Self()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void AllHeroesAgainstThemselves()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void AllHeroesAgainstDifferentClass()
        {
            Assert.IsTrue(false);
        }
    }
}
