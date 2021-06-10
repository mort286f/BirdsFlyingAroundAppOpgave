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
            List<Bird> birds = new List<Bird>() { new Sparrow(20), new Pigeon(25), new Pinguin(10), new Ostrich(70) };


            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird.GetType().Name + " speed: " + bird.Speed);
                Console.WriteLine(bird.Color);
                Console.WriteLine(bird.Eat());
                Console.WriteLine(bird.Sing());
                if (bird is IFly)
                {
                    Console.WriteLine(((IFly)bird).Fly());
                    if (bird is Sparrow)
                    {
                        Console.WriteLine("Altitude: " + ((IFly)bird).SetAltitude(10));
                        Console.WriteLine(((IFly)bird).SetLocation("Copenhagen"));
                    }
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
