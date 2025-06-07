namespace FitnessApp.Views.Registration;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void GoDataPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///DataPage");
    }

    private async void GoRegistrationPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RegistrationPage");
    }

    private async void GoToGuest(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}
