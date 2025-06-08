namespace FitnessApp.Views.SportsPages;

public partial class Sports : ContentPage
{
	public Sports()
	{
		InitializeComponent();
	}

    private async void GoHomePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }

    private async void GoProfile(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage");
    }

    private async void GoSport1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sport1");
    }

    private async void GoSport2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sport2");
    }

    private async void GoSport3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sport3");
    }

    private async void GoSport4(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sport4");
    }

    private async void GoSport5(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sport5");
    }

    private async void GoSport6(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sport6");
    }
}