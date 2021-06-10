using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundAppOpgave
{
    //Class for an ostrich
    public class Ostrich : Bird
    {
        public override double Speed { get; set; }
        public override string Color { get; set; }

        public Ostrich(double speed) :base(speed)
        {
            this.Speed = speed;
            this.Color = "An ostrich is black with white wings, legs and neck";
        }

        public override string Sing()
        {
            return $"Ostrich tries to sing but makes a weird noise";
        }

        public override string Eat()
        {
            return "Ostrich eats some food";
        }
    }
}
