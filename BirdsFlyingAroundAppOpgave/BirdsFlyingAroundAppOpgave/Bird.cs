using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundAppOpgave
{
    //Abstract class for all birds, whether they can fly or not
    public abstract class Bird
    {
        public abstract double Speed { get; set; }

        public abstract string Color { get; set; }
        public Bird(double speed)
        {
            this.Speed = speed;
        }

        public abstract string Eat();
        public abstract string Sing();
    }
}
