namespace FitnessApp.Views.TechnicalPages;

public partial class NotReady : ContentPage
{
	public NotReady()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }

    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}