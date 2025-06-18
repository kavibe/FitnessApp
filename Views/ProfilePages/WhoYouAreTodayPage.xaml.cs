using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FitnessApp.Views.ProfilePages;

public partial class WhoYouAreTodayPage : ContentPage, INotifyPropertyChanged
{
    private int _sliderValue = 50;
    public int SliderValue
    {
        get => _sliderValue;
        set
        {
            _sliderValue = value;
            OnPropertyChanged();
            UpdateUI();
        }
    }

    public WhoYouAreTodayPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void UpdateUI()
    {
        if (SliderValue < 33) // ����������� (0-32)
        {
            ShowEnergizer();
        }
        else if (SliderValue < 66) // ���������� (33-65)
        {
            ShowStable();
        }
        else // ����������� (66-100)
        {
            ShowEconomical();
        }
    }

    private void ShowEnergizer()
    {
        // �����������
        EnergizerImage.IsVisible = true;
        StableImage.IsVisible = false;
        EconomicalImage.IsVisible = false;

        // ������� ������
        EnergizerText.IsVisible = true;
        StableText.IsVisible = false;
        EconomicalText.IsVisible = false;

        // ����� ������
        EnergizerSmallText.IsVisible = true;
        StableSmallText.IsVisible = false;
        EconomicalSmallText.IsVisible = false;

        // ����� ��������
        SliderControl.MinimumTrackColor = Color.FromArgb("#A6321D");
        SliderControl.MaximumTrackColor = Color.FromArgb("#345931");
        SliderControl.ThumbColor = Color.FromArgb("#6B3603");
    }

    private void ShowStable()
    {
        // �����������
        EnergizerImage.IsVisible = false;
        StableImage.IsVisible = true;
        EconomicalImage.IsVisible = false;

        // ������� ������
        EnergizerText.IsVisible = false;
        StableText.IsVisible = true;
        EconomicalText.IsVisible = false;

        // ����� ������
        EnergizerSmallText.IsVisible = false;
        StableSmallText.IsVisible = true;
        EconomicalSmallText.IsVisible = false;

        // ����� ��������
        SliderControl.MinimumTrackColor = Color.FromArgb("#6B3603");
        SliderControl.MaximumTrackColor = Color.FromArgb("#345931");
        SliderControl.ThumbColor = Color.FromArgb("#A6321D");
    }

    private void ShowEconomical()
    {
        // �����������
        EnergizerImage.IsVisible = false;
        StableImage.IsVisible = false;
        EconomicalImage.IsVisible = true;

        // ������� ������
        EnergizerText.IsVisible = false;
        StableText.IsVisible = false;
        EconomicalText.IsVisible = true;

        // ����� ������
        EnergizerSmallText.IsVisible = false;
        StableSmallText.IsVisible = false;
        EconomicalSmallText.IsVisible = true;

        // ����� ��������
        SliderControl.MinimumTrackColor = Color.FromArgb("#345931");
        SliderControl.MaximumTrackColor = Color.FromArgb("#A6321D");
        SliderControl.ThumbColor = Color.FromArgb("#6B3603");
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private async void GoProfilePage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///ProfilePage");
    }
}