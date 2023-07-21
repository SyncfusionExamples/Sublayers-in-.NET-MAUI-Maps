using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sublayers_Maui_Maps
{
	public class Model
	{
		public String State { get; set; }
		public String DensityLevel { get; set; }
		public double DensityCount { get; set; }
		public Color Color { get; set; }
		public double Size { get; set; }

		public Model(string state, string densityLevel, double densityCount, Color color, double size)
		{
			State = state;
			DensityLevel = densityLevel;
			DensityCount = densityCount;
			Color = color;
			Size = size;
		}
	}
}
