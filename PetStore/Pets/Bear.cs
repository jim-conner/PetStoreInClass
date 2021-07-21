using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Bear
    {
        public string Type { get; set; }
        public string Name { get; set; }

        //only Bear class from inside class can change the NumberOfFishEaten value
        public int NumberOfFishEaten { get; private set; }

        //property with a default value
        public string EducationLevel { get; set; } = "GED";
        public Tiger BestTigerFriend { get; set; }

        //read only property
        //if remove set that makes the property read only
        //public bool LovesHoney { get; }

        //expression-bodied readonly property
        public bool LovesHoney => Name == "Winnie the Pooh";

        public Bear(string name, string type)
        {
            //Name = name;
            Type = type;
            //you can use logic to set the default value here
            if (name == "Winnie the Pooh")
            {
                Name = name;
                Type = type;
                EducationLevel = "GED";
            }
            else if (name == "Yogi")
            {
                EducationLevel = "Bachelor of Culinary Arts";
            }
        }
        //constructor overloading
        //delegating name,type to other class
        //expression bodied method
        public Bear(string name, string type, string educationalLevel)
            : this(name, type) => EducationLevel = educationalLevel;
        //{
        //    EducationLevel = educationalLevel;
        //}

        public void EatFish(int howMany)
        {
            if (howMany <= 0) return;

            NumberOfFishEaten += howMany;
        }

        public void HangOutWithBestFriend()
        {
            Console.WriteLine($"{Name} the Bear is hanging out with " +
                $"their best friend, {BestTigerFriend.Name} +" +
                $"the {BestTigerFriend.Size} sized tiger");
        }
    }
}
