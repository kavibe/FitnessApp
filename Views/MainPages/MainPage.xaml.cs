
namespace FitnessApp.Views.MainPages;

public partial class MainPage : ContentPage 
{
    public bool NotificationIsVisible { get; set; } = false;
    public MainPage()
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

    private async void GoProfile(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage");
    }

    private async void GoWaterPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///WaterPage");
    }
}
