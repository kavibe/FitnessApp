using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace FitnessApp.Views.ProgressPages;

public partial class WaterPage : ContentPage
{
    public bool AddWaterIsVisible { get; set; } = false;
    public bool AddWaterLimitIsVisible { get; set; } = false;

    public double CurrentWaterVolume
    {
        get => _currentWaterVolume;
        set
        {
            _currentWaterVolume = value;
            OnPropertyChanged();
        }
    }

    private double _currentWaterVolume = 0;

    public double WaterLimit
    {
        get => _waterLimit;
        set
        {
            _waterLimit = value;
            OnPropertyChanged();
        }
    }

    private double _waterLimit = 3;

    public ObservableCollection<WaterEntry> WaterEntries { get; } = new();

    public Command RemoveWaterCommand { get; }

    public WaterPage()
    {
        InitializeComponent();
        BindingContext = this;

        // Пример начальных данных
        WaterEntries.Add(new WaterEntry { Volume = 0.0 });
        WaterEntries.Add(new WaterEntry { Volume = 0.0 });

        RecalculateTotal();

        RemoveWaterCommand = new Command(OnRemove);
    }

    private void OnRemove(object obj)
    {
        if (obj is WaterEntry entry)
        {
            WaterEntries.Remove(entry);
            RecalculateTotal();
        }
    }

    private void ToggleAddWaterVisibility(object sender, EventArgs e)
    {
        AddWaterIsVisible = !AddWaterIsVisible;
        OnPropertyChanged(nameof(AddWaterIsVisible));
    }

    private void ToggleAddWaterLimitVisibility(object sender, EventArgs e)
    {
        AddWaterLimitIsVisible = !AddWaterLimitIsVisible;
        OnPropertyChanged(nameof(AddWaterLimitIsVisible));
    }

    private void SaveWaterLimit_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(WaterNormEntry.Text, out double limit))
        {
            WaterLimit = limit;
        }
    }

    private void AddQuickWater_025(object sender, EventArgs e) => AddWater(0.25);
    private void AddQuickWater_03(object sender, EventArgs e) => AddWater(0.3);
    private void AddQuickWater_05(object sender, EventArgs e) => AddWater(0.5);
    private void AddQuickWater_07(object sender, EventArgs e) => AddWater(0.7);
    private void AddQuickWater_1(object sender, EventArgs e) => AddWater(1);

    private void AddCustomWater_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(WatNormEntry.Text, out double amount))
        {
            AddWater(amount);
            WatNormEntry.Text = string.Empty;
        }
    }

    private void AddWater(double amount)
    {
        WaterEntries.Add(new WaterEntry { Volume = amount });
        RecalculateTotal();
        ToggleAddWaterVisibility(null, null); // Закрываем попап
    }

    private void RecalculateTotal()
    {
        CurrentWaterVolume = WaterEntries.Sum(e => e.Volume);
    }

    private async void GoMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}

public class WaterEntry
{
    public double Volume { get; set; }
}