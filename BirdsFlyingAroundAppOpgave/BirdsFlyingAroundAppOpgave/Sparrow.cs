using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundAppOpgave
{
    //Class for a sparrow
    public class Sparrow : Bird, IFly
    {
        public override double Speed { get; set; }
        public override string Color { get; set; }

        public Sparrow(double speed) : base(speed)
        {
            this.Speed = speed;
            this.Color = "A sparrow has brown wings and head with a white stomach";
        }

        public override string Eat()
        {
            return "Sparrow eats some seeds or corn";
        }

        public string Fly()
        {
            return "Sparrow flies a little up in the air, but not much";
        }

        public double SetAltitude(double height)
        {
            return height;
        }

        public string SetLocation(string locationName)
        {
            return $"Sparrow will fly to {locationName}";
        }

        public override string Sing()
        {
            return "Sparrow makes some tiny noises that should be a song";
        }
    }
}
