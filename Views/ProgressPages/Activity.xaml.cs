using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace FitnessApp.Views.ProgressPages;

public partial class Activity : ContentPage
{
    public bool ActivityIsVisible { get; set; } = false;
    public bool ActivityLimitIsVisible { get; set; } = false;

    public double CurrentSteps
    {
        get => _currentSteps;
        set
        {
            _currentSteps = value;
            OnPropertyChanged();
        }
    }

    private double _currentSteps = 0;

    public double StepGoal
    {
        get => _stepGoal;
        set
        {
            _stepGoal = value;
            OnPropertyChanged();
        }
    }

    private double _stepGoal = 10000;

    public string StepNormText { get; set; } = "10000";
    public string CustomStepText { get; set; }

    public ObservableCollection<StepEntry> StepEntries { get; } = new();

    public Command RemoveStepCommand { get; }

    public Activity()
    {
        InitializeComponent();
        BindingContext = this;

        // Пример начальных данных
        StepEntries.Add(new StepEntry { Steps = 0 });
        StepEntries.Add(new StepEntry { Steps = 0 });

        RecalculateTotal();

        RemoveStepCommand = new Command(OnRemove);
    }

    private void OnRemove(object obj)
    {
        if (obj is StepEntry entry)
        {
            StepEntries.Remove(entry);
            RecalculateTotal();
        }
    }

    private void ToggleActivityVisibility(object sender, EventArgs e)
    {
        ActivityIsVisible = !ActivityIsVisible;
        OnPropertyChanged(nameof(ActivityIsVisible));
    }

    private void ToggleActivityLimitVisibility(object sender, EventArgs e)
    {
        ActivityLimitIsVisible = !ActivityLimitIsVisible;
        OnPropertyChanged(nameof(ActivityLimitIsVisible));
    }

    private void SaveStepGoal_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(StepNormText, out double limit))
        {
            StepGoal = limit;
        }
    }

    private void AddQuickSteps_1000(object sender, EventArgs e) => AddSteps(1000);
    private void AddQuickSteps_2500(object sender, EventArgs e) => AddSteps(2500);
    private void AddQuickSteps_5000(object sender, EventArgs e) => AddSteps(5000);
    private void AddQuickSteps_9000(object sender, EventArgs e) => AddSteps(9000);

    private void AddCustomSteps_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(CustomStepText, out double amount))
        {
            AddSteps(amount);
            CustomStepText = string.Empty;
            OnPropertyChanged(nameof(CustomStepText));
        }
    }

    private void AddSteps(double steps)
    {
        StepEntries.Add(new StepEntry { Steps = steps });
        RecalculateTotal();
        ToggleActivityVisibility(null, null); // Закрываем попап
    }

    private void RecalculateTotal()
    {
        CurrentSteps = StepEntries.Sum(e => e.Steps);
    }

    private async void GoMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}

public class StepEntry
{
    public double Steps { get; set; }
}