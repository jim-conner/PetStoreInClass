using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Tiger
    {
        //Properties
        public string Name { get; set; }
        public string Size { get; set; }
        public int NumberOfKills { get; set; }
        public short Speed { get; set; }

        //fields prefixed with _underscore
        int _numberOfBites;

        //start method
        public void Bite (string handlerName) 
        {
            _numberOfBites++;
            if (_numberOfBites > 5)
            {
                Console.WriteLine("This is a bitey Tiger.");
            }
            Console.WriteLine(
                $" Oh shit, {Name} just bit {handlerName}! That's the {_numberOfBites} time");
        }
    }
}
