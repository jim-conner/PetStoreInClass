using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog //implicitly interal
    {
        //Access Modifiers:
        //Private: only things in this class can use it
        //^^private is default in a class 
        //public: everything can access it
        //internal: anything in this project can access it
        //protected: anything that inherits from me can access

        //Properties
        public string Size { get; set; } //auto-property
        public short Weight { get; private set; }
        public string Name { get; set; }

        //constructor method has to be same as class
        //constructor or constructor method
        public Dog(string name, short weight, string size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }

        //Method Signature
        //consists of access modifier, return type, name, parameters
        //void means not returning anything so absence of a type
        public void Bark()
        {
            Console.WriteLine($"{Name} barks loudly.");
        }

        //parameters are camelCase
        public void Eat(string typeOfFood)
        {
            if (typeOfFood.ToLower() == "Healthy Food")
            //if (string.Equals(typeOfFood, "healthy food",StringComparison.OrdinalIgnoreCase))
            {
                Weight -= 1;
            }

            Console.WriteLine($"{Name} just ate {typeOfFood}.  {Name} weighs {Weight}");
        }
    }
}
