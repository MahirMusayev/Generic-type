using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Meat:Food
    {

        public enum Type { Beef, Chicken, Fish }
        public Type MeatType { get; set; }
    }
}
