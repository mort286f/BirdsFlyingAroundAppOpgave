using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundAppOpgave
{
    //Class for a pinguin
    public class Pinguin : Bird
    {
        public override double Speed { get; set; }
        public override string Color { get; set; }

        public Pinguin(double speed) : base(speed)
        {
            this.Speed = speed;
            this.Color = "A pinguin is black with a white stomach";
        }

        public override string Eat()
        {
            return "Pinguin eats some fish";
        }

        public override string Sing()
        {
            return "Pigeons do not sing, they just make noise";
        }
    }
}
