
namespace FitnessApp.Views.Registration;

public partial class HelloPage : ContentPage
{
    public HelloPage()
    {
        InitializeComponent();
    }

    public async void OnScreenTappedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MotivationPage");
    }

    private async void GoLoginPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///LoginPage");
    }
}
