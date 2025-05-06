using FitnessApp.Views.MainPages;
using FitnessApp.Views.Registration;

namespace FitnessApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
