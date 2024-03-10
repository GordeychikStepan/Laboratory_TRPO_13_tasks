using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task1
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

		private void MenuItemBackground_Click(object sender, RoutedEventArgs e)
		{
			if (sender is MenuItem menuItem)
			{
				string? colorName = menuItem.Header.ToString();
				if (colorName == "Красный") Background = Brushes.Red;
				else if (colorName == "Зеленый") Background = Brushes.Green;
				else if (colorName == "Синий") Background = Brushes.Blue;
			}
		}

		private void MenuItemDeveloperInfo_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Разработал - Гордейчик Степан", "Информация о разработчике", 
				MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void ButtonBackground_Click(object sender, RoutedEventArgs e)
		{
			if (sender is Button button)
			{
				string? colorName = button.Content.ToString();
				if (colorName == "Красный") Background = Brushes.Red;
				else if (colorName == "Зеленый") Background = Brushes.Green;
				else if (colorName == "Синий") Background = Brushes.Blue;
			}
		}

		private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			if (sender is MenuItem menuItem) statusLabel.Text = "Пункт меню: " + menuItem.Header.ToString();
		}

		private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
		{
			if (sender is Button button) statusLabel.Text = "Кнопка: " + button.Content.ToString();
		}

		private void MenuItem_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e) => statusLabel.Text = "Готово";

		private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e) => statusLabel.Text = "Готово";

		private void MenuItemExit_Click(object sender, RoutedEventArgs e) => this.Close();
	}
}