using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Balancing
{
    using AntTool;

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FirstHeroIsNoHero()
        {
            Assert.AreEqual(HeroesData.instance.Rows[0]._Name, "No Hero");
        }

        [TestMethod]
        public void AllHeroStatsAreWithinLimits()
        {
            const int LowerLimit = 200;
            const int UpperLimit = 600;
            foreach (var Hero in HeroesData.instance.Rows)
            {
                if (Hero._TestFrame)
                {
                    int TotalValue = Hero._STR + Hero._DEX + Hero._LUK + Hero._INT;
                    bool TestPass = TestHelpers.ValueIsBetween(TotalValue, LowerLimit, UpperLimit);
                    Assert.IsTrue(TestPass, Hero._Name + " failed! Limit:" + TotalValue);
                }
            }
        }

        [TestMethod]
        public void AllHeroesShouldKillTheirLevel1SelfIn2To5Hits()
        {
            const int LowerLimit = 2;
            const int UpperLimit = 5;
            const int MaxLevel = 10;
            foreach (var Hero in HeroesData.instance.Rows)
            {
                if (Hero._TestFrame)
                {
                    int TotalValue = Hero._Att + Hero._AttGrowth * MaxLevel;
                    float Hits = Hero._HP/TotalValue;
                    bool TestPass = TestHelpers.ValueIsBetween(Hits, LowerLimit, UpperLimit);
                    Assert.IsTrue(TestPass, Hero._Name + " failed! Hits:" + Hits);
                }
            }
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
