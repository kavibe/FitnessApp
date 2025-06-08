namespace FitnessApp.Views.TechnicalPages;

public partial class NotReady : ContentPage
{
	public NotReady()
	{
		InitializeComponent();
	}

    private async void GoSports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sports");
    }
}