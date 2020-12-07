using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFourChallenges
{
    abstract public class Animal
    {
        public string Name { get; set; }
        public string Biome { get; set; }
        public string Food { get; set; }

        public Animal() { }

        public Animal(string name, string biome, string food)
        {
            Name = name;
            Biome = biome;
            Food = food;
        }
    }

    public class Zebra : Animal
    {
        public bool IsAdorable { get; set; }

    }

    public class Squid : Animal
    {
        public bool canCamouflage { get; set; }
    }

    public class Tiger : Animal
    {
        public bool isSuperCool { get; set; }
    }
}
