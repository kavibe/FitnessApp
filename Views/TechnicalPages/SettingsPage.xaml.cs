namespace FitnessApp.Views.TechnicalPages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private async void GoProfilePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage");
    }

    private async void GoRulesPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RulesPage");
    }
}