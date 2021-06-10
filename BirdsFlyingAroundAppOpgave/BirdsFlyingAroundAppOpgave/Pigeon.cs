using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundAppOpgave
{
    //Class for a pigeon
    public class Pigeon : Bird, IFly
    {
        public override double Speed { get; set; }
        public override string Color { get; set; }

        public Pigeon(double speed) : base(speed)
        {
            this.Speed = speed;
            this.Color = "A pigeon is grey and white";
        }

        public override string Eat()
        {
            return "Pigeon eats";
        }

        public string Fly()
        {
            return "Pigeon flies high in the air";
        }

        public double SetAltitude(double height)
        {
            return height;
        }

        public string SetLocation(string locationName)
        {
            return $"Pigeon will fly to {locationName}";
        }

        public override string Sing()
        {
            return "Pigeon tries to sing and it sounds okay-ish";
        }
    }
}
