using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePatterns
{
    public abstract class SpaceType
    {
        public SpaceType.TypeOfSpace typeOfSpace { get; set; }
        public enum TypeOfSpace
        {
            GasGiant,
            Star,
        };
		//
    }
}
