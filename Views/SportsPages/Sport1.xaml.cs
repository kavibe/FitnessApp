namespace FitnessApp.Views.SportsPages;

public partial class Sport1 : ContentPage
{
	public Sport1()
	{
		InitializeComponent();
	}

    private async void GoSports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sports");
    }
}