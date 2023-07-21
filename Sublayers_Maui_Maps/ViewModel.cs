using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sublayers_Maui_Maps
{
	public class ViewModel
	{
		public ObservableCollection<Model> Data { get; set; }

		public ViewModel()
		{
			Data = new ObservableCollection<Model>();
			Data.Add(new Model("Algeria", "Low", 17, Colors.Green, 5));
			Data.Add(new Model("Libya", "Low", 4, Colors.Teal, 10));
			Data.Add(new Model("Egypt", "High", 92, Colors.Blue, 7));
			Data.Add(new Model("Nigeria", "High", 197, Colors.MediumPurple, 9));
			Data.Add(new Model("Sudan", "Low", 22, Colors.IndianRed, 6));
			Data.Add(new Model("Uganda", "High", 165, Colors.Lime, 9));
			Data.Add(new Model("South Africa", "Low", 48, Colors.GreenYellow, 7));
		}
	}
}
