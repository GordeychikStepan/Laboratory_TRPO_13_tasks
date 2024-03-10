using System.Windows;

namespace Task2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var blackDrawingAttribute = ((MyDrawingAttribute[])Resources["MyDrawingAttributes"])[0];

			colorComboBox.SelectedValue = blackDrawingAttribute;

			inkCanvas.DefaultDrawingAttributes = blackDrawingAttribute;
			inkCanvas.DefaultDrawingAttributes.Width = sizeSlider.Value;
			inkCanvas.DefaultDrawingAttributes.Height = sizeSlider.Value;
			inkCanvas.DefaultDrawingAttributes.FitToCurve = true;
		}


		private void sizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (inkCanvas != null)
			{
				inkCanvas.DefaultDrawingAttributes.Width = sizeSlider.Value;
				inkCanvas.DefaultDrawingAttributes.Height = sizeSlider.Value;
			}
		}
	}
}