using System.Windows;

namespace Triggers_Task
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

		private void CloseCommand_Executed(object sender, RoutedEventArgs e) => Close();

		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;
		}
	}
}