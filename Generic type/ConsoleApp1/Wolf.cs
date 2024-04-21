using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Wolf:Animal
    {
        public bool IsPrideLeader { get; set; }
        public int AttackDamage { get; set; }
        public override void Hunt<T>(T animal)
        {
            if (animal != null)
            {
                animal.HP -= AttackDamage;
                Console.WriteLine($"The {GetType().Name} attacked the {animal.GetType().Name}. New HP: {animal.HP}");
            }
        }
    }
}
