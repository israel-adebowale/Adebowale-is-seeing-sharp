using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyApp
{
    public class Passenger
    {
        public string Name { get; }
        public string Destination { get; init; }
        public Passenger(string name, string destination)
        {
            Name = name;
            Destination = destination; 
        }
        public override string ToString() => $"{Name} to {Destination}"; 
       
    }
}
