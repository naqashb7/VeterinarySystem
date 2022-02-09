using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarySystem
{
    public abstract class Animal
    {

        public int Age { get; set; }
        public String Name { get; set; }


        public Animal()
            : base()
        {
            Name = "El Animal";
        }


        public abstract void Eat(String food);

        public void Sleep(int lengthOfSleep)
        {
            //code sleep method
        }


        public abstract Animal Reproduce(Animal otherParent);

        public abstract void Breathe();
        public String Poo()
        {
            return "The animal has pooed";
        }


        public void Die()
        {
            //add die method
        }
    }
}
