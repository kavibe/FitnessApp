namespace FitnessApp.Views.SportsPages;

public partial class Sport2 : ContentPage
{
	public Sport2()
	{
		InitializeComponent();
	}

    private async void GoSports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sports");
    }
}