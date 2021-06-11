using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundAppOpgave
{
    //Interface for all flyers/birds that can fly
    interface IFly
    {
        string SetLocation(string locationName);
        double SetAltitude(double height);
        string Fly();
    }
}
