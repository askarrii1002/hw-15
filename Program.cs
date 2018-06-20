using System;

namespace hw15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Long ago in Milwaukee,WI there was a power planet explosion turning humans into unorthadox creatures; giving them dark power! ");
            Console.ReadKey();

            Console.WriteLine("In order to put an stop to the evil corruption 3 teenagers was hand choosen to protect the city of Milwaukee!");
            Console.ReadKey();

            Console.WriteLine("All of sudden, The green goblin  demon appeared terrorizing 3rd ward!");
            Console.ReadKey();


            Console.WriteLine("The POWER RANGERS come to the defense of civilians.");
            Console.ReadKey();

            powerRangers redRanger = new powerRangers("Jace", "red", 10, "superstrength");

            // Get
            int Strength = redRanger._abilityLevel; //10

            // Set
            redRanger._abilityLevel = 30;

            Console.WriteLine(".......................To be continued");
            Console.ReadKey();












        }

        private static int NewMethod()
        {
            return 20;
        }
    }
}
