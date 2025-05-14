namespace FitnessApp.Views.Registration;

public partial class DataPage : ContentPage
{
	public DataPage()
	{
		InitializeComponent();
	}

    private async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///LoginPage");
    }
}
