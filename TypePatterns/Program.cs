using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet Jupiter = new Planet()
            {
                Name = "Jupiter",
                typeOfSpace = SpaceType.TypeOfSpace.GasGiant
            };
			//
            Star Aldebaran = new Star()
            {
                Name = "Aldebaran",
                typeOfSpace = SpaceType.TypeOfSpace.Star
            };

            SpaceCraft.MakeDecision(Jupiter);
            SpaceCraft.MakeDecision(Aldebaran);
        }
    }
}
