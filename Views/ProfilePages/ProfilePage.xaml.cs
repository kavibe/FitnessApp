namespace FitnessApp.Views.ProfilePages;

public partial class ProfilePage : ContentPage
{
    public bool NotificationIsVisible { get; set; } = false;
    public ProfilePage()
	{
		InitializeComponent();

        BindingContext = this;
    }

    private void ToggleNotificationVisibility(object sender, EventArgs e)
    {
        NotificationIsVisible = !NotificationIsVisible;
        OnPropertyChanged(nameof(NotificationIsVisible)); // Уведомляем об изменении
    }

    private async void GoSports(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///Sports");
    }

    private async void GoHomePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }

    private async void GoLoginPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///LoginPage");
    }

    private async void GoSettingsPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///SettingsPage");
    }
}