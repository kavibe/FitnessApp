using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace FitnessApp.Views.ProfilePages;

public partial class AI : ContentPage
{
    private const string TelegramWebUrl = "https://web.telegram.org/k/#@FitnessBearBot";

    public AI()
    {
        InitializeComponent();
        LoadTelegramWeb();
    }

    private void LoadTelegramWeb()
    {
        var source = new UrlWebViewSource
        {
            Url = TelegramWebUrl
        };

        TelegramWebView.Source = source;
    }

    private void OnNavigating(object sender, WebNavigatingEventArgs e)
    {
        // ����� �������� ��������� ����� ��������� ��������
        if (!e.Url.StartsWith("https://web.telegram.org"))
        {
            e.Cancel = true; // ��������� �������� �� ��������� �����
        }
    }

    private void OnNavigated(object sender, WebNavigatedEventArgs e)
    {
        // �������� ����� �������� ��������
    }

    private async void GoProfilePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage");
    }
}
