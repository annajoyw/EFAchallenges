using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week2Challenges
{
    [TestClass]
    public class greeter
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");

            string Name = Console.ReadLine();

            Console.WriteLine("Hello" + Name);
        }

        public void Farewell(string Name1)
        {
            Console.WriteLine(Name1 + "goodbye have a great day!");
        }
        static void Farewell(string[] args)
        {
            string Name1 = Console.ReadLine();
        }
           

    }
    [TestMethod]
    public void TimeOfDay()
    {
        

    }
}
