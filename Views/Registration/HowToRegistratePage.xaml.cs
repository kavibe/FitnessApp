namespace FitnessApp.Views.Registration;

public partial class HowToRegistratePage : ContentPage
{
	public HowToRegistratePage()
	{
		InitializeComponent();
	}

    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///LoginPage");
    }
}
