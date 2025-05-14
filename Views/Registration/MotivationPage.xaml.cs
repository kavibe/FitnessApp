namespace FitnessApp.Views.Registration;

public partial class MotivationPage : ContentPage
{
    public MotivationPage()
    {
        InitializeComponent();
    }

    public async void OnScreenTappedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///BearHelloPage");
    }

    public async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HelloPage");
    }

    private async void GoLoginPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///LoginPage");
    }
}
