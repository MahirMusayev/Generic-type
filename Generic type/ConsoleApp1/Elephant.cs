using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Elephant:Animal
    {
        public double Weight { get; set; }

        public bool IsTrained { get; set; }


        public override void Hunt<T>(T animal)
        {
            Console.WriteLine("Elephants are not hunters");
        }
    }
}
