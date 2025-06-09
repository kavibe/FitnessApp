namespace FitnessApp.Views.TechnicalPages;

public partial class RulesPage : ContentPage
{
	public RulesPage()
	{
		InitializeComponent();
	}

    private async void GoSettingsPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///SettingsPage");
    }
}