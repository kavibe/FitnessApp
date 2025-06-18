using FitnessApp.Views.TechnicalPages;

namespace FitnessApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("NotReady", typeof(NotReady));
    }
}
