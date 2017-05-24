using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePatterns
{
	static class SpaceCraft
	{
		internal static string Name = "Voyager 278";

		public static void MakeDecision(SpaceType spaceItem)
        {
            switch (spaceItem)
            {
                case Planet p:
                    if (p.typeOfSpace == SpaceType.TypeOfSpace.GasGiant)
                        LandSpaceCraft(p);
                    break;
                case Star s:
                    AvoidHeatSource(s);
                    break;
                case null:
                    break;
                default:
                    break;

            }
        }

		private static void AvoidHeatSource(Star s)
		{
			Console.WriteLine("Star named {0} detected. Avoiding heat source.", s.Name, s.typeOfSpace);
		}

		private static void LandSpaceCraft(Planet p)
		{
			Console.WriteLine("Planet {0} detected. {1} landing.", p.Name, SpaceCraft.Name);
		}
	}
}
