using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarySystem
{
    public class Rabbit: Mammal
    {

        public Rabbit(String Name, int Age, String Breed, double Weight) : base(Name, Age, Breed, Weight)
        {

        }
        public override void Eat(string food)
        {
            //implement later
        }
        public void AnimalSound()
        {
            Console.WriteLine("Ribbit... oh wait I'm a rabbit");
        }
    }
}
