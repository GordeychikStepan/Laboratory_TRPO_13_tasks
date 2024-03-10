using System.Globalization;
using System.Windows.Data;

namespace Triggers_Task
{
	public class MultiBoolConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			foreach (object value in values) 
				if (!string.IsNullOrEmpty((string)value)) return false;

			return true;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotSupportedException();
	}
}
