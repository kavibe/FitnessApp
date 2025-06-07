namespace FitnessApp.Views.SportsPages;

public partial class Sport4 : ContentPage
{
	public Sport4()
	{
		InitializeComponent();
	}

    private async void GoSports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sports");
    }
}