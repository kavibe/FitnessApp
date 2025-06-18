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
        if (SliderValue < 33) // Энерджайзер (0-32)
        {
            ShowEnergizer();
        }
        else if (SliderValue < 66) // Стабильный (33-65)
        {
            ShowStable();
        }
        else // Экономичный (66-100)
        {
            ShowEconomical();
        }
    }

    private void ShowEnergizer()
    {
        // Изображения
        EnergizerImage.IsVisible = true;
        StableImage.IsVisible = false;
        EconomicalImage.IsVisible = false;

        // Большие тексты
        EnergizerText.IsVisible = true;
        StableText.IsVisible = false;
        EconomicalText.IsVisible = false;

        // Малые тексты
        EnergizerSmallText.IsVisible = true;
        StableSmallText.IsVisible = false;
        EconomicalSmallText.IsVisible = false;

        // Цвета слайдера
        SliderControl.MinimumTrackColor = Color.FromArgb("#A6321D");
        SliderControl.MaximumTrackColor = Color.FromArgb("#345931");
        SliderControl.ThumbColor = Color.FromArgb("#6B3603");
    }

    private void ShowStable()
    {
        // Изображения
        EnergizerImage.IsVisible = false;
        StableImage.IsVisible = true;
        EconomicalImage.IsVisible = false;

        // Большие тексты
        EnergizerText.IsVisible = false;
        StableText.IsVisible = true;
        EconomicalText.IsVisible = false;

        // Малые тексты
        EnergizerSmallText.IsVisible = false;
        StableSmallText.IsVisible = true;
        EconomicalSmallText.IsVisible = false;

        // Цвета слайдера
        SliderControl.MinimumTrackColor = Color.FromArgb("#6B3603");
        SliderControl.MaximumTrackColor = Color.FromArgb("#345931");
        SliderControl.ThumbColor = Color.FromArgb("#A6321D");
    }

    private void ShowEconomical()
    {
        // Изображения
        EnergizerImage.IsVisible = false;
        StableImage.IsVisible = false;
        EconomicalImage.IsVisible = true;

        // Большие тексты
        EnergizerText.IsVisible = false;
        StableText.IsVisible = false;
        EconomicalText.IsVisible = true;

        // Малые тексты
        EnergizerSmallText.IsVisible = false;
        StableSmallText.IsVisible = false;
        EconomicalSmallText.IsVisible = true;

        // Цвета слайдера
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