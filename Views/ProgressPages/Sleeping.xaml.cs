using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace FitnessApp.Views.ProgressPages;

public partial class Sleeping : ContentPage
{
    public bool SleepingIsVisible { get; set; } = false;
    public bool SleepingLimitIsVisible { get; set; } = false;

    public double CurrentSleepHours
    {
        get => _currentSleepHours;
        set
        {
            _currentSleepHours = value;
            OnPropertyChanged();
        }
    }

    private double _currentSleepHours = 0;

    public double SleepGoal
    {
        get => _sleepGoal;
        set
        {
            _sleepGoal = value;
            OnPropertyChanged();
        }
    }

    private double _sleepGoal = 8;

    public string SleepNormText { get; set; } = "8";
    public string CustomSleepText { get; set; }

    public ObservableCollection<SleepEntry> SleepEntries { get; } = new();

    public Command RemoveSleepCommand { get; }

    public Sleeping()
    {
        InitializeComponent();
        BindingContext = this;

        // Пример начальных данных
        SleepEntries.Add(new SleepEntry { Hours = 0 });
        SleepEntries.Add(new SleepEntry { Hours = 0 });

        RecalculateTotal();

        RemoveSleepCommand = new Command(OnRemove);
    }

    private void OnRemove(object obj)
    {
        if (obj is SleepEntry entry)
        {
            SleepEntries.Remove(entry);
            RecalculateTotal();
        }
    }

    private void ToggleSleepingVisibility(object sender, EventArgs e)
    {
        SleepingIsVisible = !SleepingIsVisible;
        OnPropertyChanged(nameof(SleepingIsVisible));
    }

    private void ToggleSleepingLimitVisibility(object sender, EventArgs e)
    {
        SleepingLimitIsVisible = !SleepingLimitIsVisible;
        OnPropertyChanged(nameof(SleepingLimitIsVisible));
    }

    private void SaveSleepGoal_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(SleepNormText, out double limit))
        {
            SleepGoal = limit;
        }
    }

    private void AddQuickSleep_6(object sender, EventArgs e) => AddSleep(6);
    private void AddQuickSleep_7(object sender, EventArgs e) => AddSleep(7);
    private void AddQuickSleep_8(object sender, EventArgs e) => AddSleep(8);
    private void AddQuickSleep_9(object sender, EventArgs e) => AddSleep(9);

    private void AddCustomSleep_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(CustomSleepText, out double amount))
        {
            AddSleep(amount);
            CustomSleepText = string.Empty;
            OnPropertyChanged(nameof(CustomSleepText));
        }
    }

    private void AddSleep(double hours)
    {
        SleepEntries.Add(new SleepEntry { Hours = hours });
        RecalculateTotal();
        ToggleSleepingVisibility(null, null); // Закрываем попап
    }

    private void RecalculateTotal()
    {
        CurrentSleepHours = SleepEntries.Sum(e => e.Hours);
    }

    private async void GoMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}

public class SleepEntry
{
    public double Hours { get; set; }
}