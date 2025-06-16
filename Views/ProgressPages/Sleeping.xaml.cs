namespace FitnessApp.Views.ProgressPages;

public partial class Sleeping : ContentPage
{
    public bool SleepingIsVisible { get; set; } = false;
    public bool SleepingLimitIsVisible { get; set; } = false;
    public Sleeping()
	{
		InitializeComponent();
        BindingContext = this;  
	}

    public void ToggleSleepingVisibility(object sender, EventArgs e)
    {
        SleepingIsVisible = !SleepingIsVisible;
        OnPropertyChanged(nameof(SleepingIsVisible));
    }

    public void ToggleSleepingLimitVisibility(object sender, EventArgs e)
    {
        SleepingLimitIsVisible = !SleepingLimitIsVisible;
        OnPropertyChanged(nameof(SleepingLimitIsVisible));
    }

    private async void GoMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}