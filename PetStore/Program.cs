using PetStore.Pets;
using System;
//order doesn't matter like it does for JS imports
//using PetStore.Pets;

namespace PetStore
{
    class Program
    {
        //static means shared across all instances
        static void Main(string[] args)
        {
            //var melba = new Dog();
            //melba.Name = "Melba";
            //melba.Size = "Medium";
            //melba.Weight = 60;
            var melba = new Dog("Melba", 60, "Weight");
            melba.Bark();

            Console.WriteLine($"What kind of food should {melba.Name} eat?");
            var typeOfFoodForMelba = Console.ReadLine();

            melba.Eat(typeOfFoodForMelba);
            //add a line here for user's input response

            melba.Eat("healthy food");

            var barley = new Dog("Barley", 60, "Medium");
            //barley.Name = "Barley";
            //barley.Size = "Medium";
            //barley.Weight = 50;
            barley.Bark();

            barley.Eat("kitchen trash");

            //this won't work bc can't dynamically add properties to a class in C#
            //melba.Coat = "Short";
        }
    }
}
