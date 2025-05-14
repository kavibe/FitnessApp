namespace FitnessApp.Views.Registration;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private async void GoHowToRegisrtratePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HowToRegistratePage");
    }
}

