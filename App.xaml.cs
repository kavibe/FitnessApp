using System.Globalization;
using FitnessApp.Views.MainPages;
using FitnessApp.Views.ProgressPages;
using FitnessApp.Views.Registration;

namespace FitnessApp;

public partial class App : Application
{
    public static Sleeping Sleeping { get; set; } = new Sleeping();
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    public class AlignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? LayoutOptions.Start : LayoutOptions.End;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }

    public class BgColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? Colors.LightGray : Color.FromArgb("#0088cc");


        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class TextColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => (bool)value ? Colors.Black : Colors.White;


        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
