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
        OnPropertyChanged(nameof(NotificationIsVisible)); // ���������� �� ���������
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

    private async void GoWhoAreYou(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///WhoAreYou");
    }

    private async void GoNotReady(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("NotReady");
    }

    private async void OpenTelegramBot(object sender, EventArgs e)
    {
        try
        {
            string botUsername = "FitnessBearBot"; // ��� @ � ��� https://t.me/
            string uri = DeviceInfo.Platform == DevicePlatform.Android
                ? $"tg://resolve?domain={botUsername}"  // �������� ������ ��� Android
                : $"https://t.me/{botUsername}";        // ��� iOS � ������ ��������

            bool canOpen = await Launcher.CanOpenAsync(new Uri(uri));

            if (canOpen)
            {
                await Launcher.Default.OpenAsync(new Uri(uri));
            }
            else
            {
                // ���� Telegram �� ����������, ��������� � ��������
                await Launcher.Default.OpenAsync(new Uri($"https://t.me/{botUsername}"));
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("������", $"�� ������� ������� Telegram: {ex.Message}", "OK");
        }
    }
}