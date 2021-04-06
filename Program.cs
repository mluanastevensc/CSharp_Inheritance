using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONECreate a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // DONECreate a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal .




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "pink";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 3.5;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile()
            {
                IsAlive = true,
                IsScaly=true,
                IsColdBlooded = true,
                RegrowTail = true,
                Habitat = "swamp",

            };
            //var myAnimals = new Animal[2];
            var myAnimals = new Animal[] { myBird, lizard }; // both inherite from Animal
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($" Is Alive?: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"It has {animal.LegCount} legs");
            }

        }
    }
}
