using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarySystem
{
    public abstract class Mammal : Animal
    {


       
        public Mammal(String Name, int Age, String Breed, double Weight) : base ( Name, Age, Breed, Weight) { 

            
}
           


        public override void Breathe()
        {
            //implement a breathe method
        }

        public override Mammal Reproduce(Animal otherParent)
        {
            return null;
        }
    }
}
