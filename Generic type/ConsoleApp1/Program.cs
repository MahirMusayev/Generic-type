namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf { AvgLifeTime = 30, Breed = " Wolf", HP = 300, IsPrideLeader = true, AttackDamage = 20 };
            Elephant elephant = new Elephant { AvgLifeTime = 60, Breed = " Elephant", HP = 300, Weight = 5000, IsTrained = false };
            Meat meat = new Meat { Calorie = 200, MeatType = Meat.Type.Beef };
            Grass grass = new Grass { Calorie = 50, Name = "black Grass" };


            ZooCage<Wolf, Meat> wolfCage = new ZooCage<Wolf, Meat> { Animal = wolf, Food = meat };
            ZooCage<Elephant, Grass> elephantCage = new ZooCage<Elephant, Grass> { Animal = elephant, Food = grass };

            wolf.Hunt(elephant);
            elephant.Hunt(wolf);


        }
    }
}
