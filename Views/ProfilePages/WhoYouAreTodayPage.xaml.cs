namespace FitnessApp.Views.ProfilePages;

public partial class WhoYouAreTodayPage : ContentPage
{
	public WhoYouAreTodayPage()
	{
		InitializeComponent();
	}

    private async void GoProfilePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage");
    }
}