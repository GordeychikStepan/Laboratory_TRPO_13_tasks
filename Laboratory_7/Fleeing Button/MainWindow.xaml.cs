using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Fleeing_Button
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Random random = new();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void fleeingButton_MouseEnter(object sender, MouseEventArgs e)
		{
			double newX = random.Next(0, (int)(ActualWidth - fleeingButton.ActualWidth - 50));
			double newY = random.Next(0, (int)(ActualHeight - fleeingButton.ActualHeight - 50));

			fleeingButton.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(newX, newY, 0, 0), TimeSpan.FromSeconds(0.3)));
		}
	}
}