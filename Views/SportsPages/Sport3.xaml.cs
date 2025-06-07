namespace FitnessApp.Views.SportsPages;

public partial class Sport3 : ContentPage
{
	public Sport3()
	{
		InitializeComponent();
	}

    private async void GoSports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sports");
    }
}