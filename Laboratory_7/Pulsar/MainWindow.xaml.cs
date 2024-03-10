using System.Windows;
using System.Windows.Media.Animation;

namespace Pulsar
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private bool isExpanding = true;

		public MainWindow()
		{
			InitializeComponent();
			StartAnimation();
		}

		private void StartAnimation()
		{
			DoubleAnimation animation = new()
			{
				From = 0.1,
				To = 1,
				Duration = TimeSpan.FromSeconds(2),
				AutoReverse = true,
				RepeatBehavior = RepeatBehavior.Forever
			};

			Storyboard storyboard = new();

			storyboard.Children.Add(animation);

			Storyboard.SetTarget(animation, circle);
			Storyboard.SetTargetProperty(animation, new PropertyPath("Fill.(RadialGradientBrush.GradientStops)[1].Offset"));

			storyboard.Completed += (sender, e) =>
			{
				isExpanding = !isExpanding;

				if (isExpanding)
				{
					animation.To = 1;
					animation.Duration = TimeSpan.FromSeconds(2);
				}
				else
				{
					animation.To = 0;
					animation.Duration = TimeSpan.FromSeconds(1);
				}
			};

			storyboard.Begin();
		}
	}
}