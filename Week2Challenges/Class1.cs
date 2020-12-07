using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
   public class Greeter
    {
        //-- method here, input Anna, output "hello Anna!"
        public static void Main(string[]args)
        {
            Console.WriteLine("what is your name?");
           
            string Name = Console.ReadLine();

            Console.WriteLine("Hello" + Name);
        }
        
       
    }


}
