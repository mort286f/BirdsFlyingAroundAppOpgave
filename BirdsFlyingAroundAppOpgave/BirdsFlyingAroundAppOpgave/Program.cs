using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundAppOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //A new list of birds for console printing purpose
            List<Bird> birds = new List<Bird>() { new Sparrow(20), new Pigeon(25), new Pinguin(10), new Ostrich(70) };

            //Loop for checking which type of bird it is and output data about it
            foreach (Bird bird in birds)
            {
                //Every bird prints speed, color, eat, and sing (or tries to)
                Console.WriteLine(bird.GetType().Name + " speed: " + bird.Speed);
                Console.WriteLine(bird.Color);
                Console.WriteLine(bird.Eat());
                Console.WriteLine(bird.Sing());
                
                //If the Bird is also of the type IFly, then it outputs aditional data
                if (bird is IFly)
                {
                    Console.WriteLine(((IFly)bird).Fly());
                    //If the specific bird is a Sparrow and implements IFly
                    if (bird is Sparrow)
                    {
                        Console.WriteLine("Altitude: " + ((IFly)bird).SetAltitude(10));
                        Console.WriteLine(((IFly)bird).SetLocation("Copenhagen"));
                    }
                    //If the bird is a Pigeon and implements IFly
                    else if (bird is Pigeon)
                    {
                        Console.WriteLine("Altitude: " + ((IFly)bird).SetAltitude(30));
                        Console.WriteLine(((IFly)bird).SetLocation("Slagelse"));
                    }
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
