using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace MultiEdit
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			TextBox? textBox = sender as TextBox;
			Storyboard? storyboard = Resources["TextBoxHeightAnimation"] as Storyboard;

			double targetHeight = (textBox == largeTextBox || textBox == largeTextBox2) ? 200 : 100;
			double targetWidth = (textBox == largeTextBox || textBox == largeTextBox2) ? 300 : 200;

			storyboard?.Stop();
			storyboard?.Children.Clear();
			var heightAnimation = new DoubleAnimation(targetHeight, TimeSpan.FromSeconds(0.5));
			var widthAnimation = new DoubleAnimation(targetWidth, TimeSpan.FromSeconds(0.5));
			storyboard?.Children.Add(heightAnimation);
			storyboard?.Children.Add(widthAnimation);

			heightAnimation.Completed += (s, _) =>
			{
				if (sender == largeTextBox)
				{
					largeTextBox.Style = (Style)Resources["LargeTextBoxActiveStyle"];
					largeTextBox2.Style = (Style)Resources["SmallTextBoxStyle"];
				}
				else if (sender == largeTextBox2)
				{
					largeTextBox2.Style = (Style)Resources["LargeTextBoxActiveStyle"];
					largeTextBox.Style = (Style)Resources["SmallTextBoxStyle"];
				}
			};

			Storyboard.SetTarget(heightAnimation, textBox);
			Storyboard.SetTargetProperty(heightAnimation, new PropertyPath(TextBox.HeightProperty));

			Storyboard.SetTarget(widthAnimation, textBox);
			Storyboard.SetTargetProperty(widthAnimation, new PropertyPath(TextBox.WidthProperty));

			storyboard?.Begin();
		}
	}
}