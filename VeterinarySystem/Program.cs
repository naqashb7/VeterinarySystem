using System;

namespace VeterinarySystem;

public class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("What pet are you bringing in today?");
        
        
        
        
        Dog mydog  = new Dog("John", 12, "German Shepherd", 60);
        Console.WriteLine(mydog.AnimalSound);

        
        
    }

}