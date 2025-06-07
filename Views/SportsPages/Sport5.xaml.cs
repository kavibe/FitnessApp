namespace FitnessApp.Views.SportsPages;

public partial class Sport5 : ContentPage
{
	public Sport5()
	{
		InitializeComponent();
	}

    private async void GoSports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sports");
    }
}