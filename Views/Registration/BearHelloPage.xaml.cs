namespace FitnessApp.Views.Registration;

public partial class BearHelloPage : ContentPage
{
	public BearHelloPage()
	{
		InitializeComponent();
	}

    public async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MotivationPage");
    }

    private async void GoNext(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///LoginPage");
    }
}
