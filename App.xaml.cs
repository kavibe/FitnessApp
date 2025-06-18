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
}
