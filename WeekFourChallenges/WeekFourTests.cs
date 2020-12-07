using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeekFourChallenges
{
    [TestClass]
    public class WeekFourTests
    {
        [TestMethod]
        public void AnimalExamples()
        {
            var zebra = new Zebra();
            zebra.Name = "Zebra";
            zebra.Biome = "Grasslands, Savannas";
            zebra.Food = "Grass";
            zebra.IsAdorable = true;

            var squid = new Squid();
            squid.Name = "Squid";
            squid.Biome = "Marine";
            squid.Food = "Fish, Shrip, Crab";
            squid.canCamouflage = true;

            var tiger = new Tiger();
            tiger.Name = "Tiger";
            tiger.Biome = "Rain Forest, Grasslands, Savannas";
            tiger.Food = "Deer, Pigs, Buffalo, Antelope";
            tiger.isSuperCool = true;
        }
    }
}
