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
        public String Breed { get; set; }
        public double Weight { get; set; }  


        public Animal(String Name, int Age, String Breed, double Weight)
            
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.Breed = Breed;
        }


        public abstract void Eat(String food);

        public void Sleep(int lengthOfSleep)
        {
            if(lengthOfSleep.Equals(8))
            {
                Console.WriteLine("I am rested");
            }
            else if(lengthOfSleep > 8)
            {
                Console.WriteLine("Sleep is life");
            }
            else
            {
                Console.WriteLine("DON'T ANNOY ME I AM TIRED");
            }
        }


        public abstract Animal Reproduce(Animal otherParent);

        public abstract void Breathe();
        public String Poo()
        {
            return "I seem to have soiled myself";
        }


        public String Die()
        {
            if (Age > 50)
            {
                return "Oh no! I see the light";
            }
            else if (Age < 50 && Age > 10)
            {
                return "I can still travel the world";
            }
            else
            {
                return "Gaa gaa goo gaa";
            }

        }

        public void AnimalSound()
        {

        }
    }
}
