using System;
namespace Interfaces
{
    public class Dog : IDogWalker
    {
        public void DogBarking()
        {
            Console.WriteLine("Bark bark");
        }

        public void WalkToTheCity()
        {
            Console.WriteLine("Walk to the city.");
        }

        public void WalkToTheFoodBowl()
        {
            Console.WriteLine("Walk to the food bowl.");
        }

        public void WalkToThePark()
        {
            Console.WriteLine("Walk to the Park.");
        }
    }
}

