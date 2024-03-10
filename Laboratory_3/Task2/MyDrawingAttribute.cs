using System.Windows.Ink;
using System.Windows.Media;

namespace Task2
{
	public class MyDrawingAttribute : DrawingAttributes
	{
		public string Name { get; set; }

		public MyDrawingAttribute() { }

		public MyDrawingAttribute(Color color, double width, double height, string name)
		{
			this.Color = color;
			this.Width = width;
			this.Height = height;
			this.Name = name;
		}
	}
}
