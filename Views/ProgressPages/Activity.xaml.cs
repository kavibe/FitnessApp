namespace FitnessApp.Views.ProgressPages;
public partial class Activity : ContentPage
{
    public bool ActivityIsVisible { get; set; } = false;
    public bool ActivityLimitIsVisible { get; set; } = false;
    public Activity()
	{
		InitializeComponent();
        BindingContext = this;
	}

    public void ToggleActivityVisibility(object sender, EventArgs e)
    {
        ActivityIsVisible = !ActivityIsVisible;
        OnPropertyChanged(nameof(ActivityIsVisible));
    }

    public void ToggleActivityLimitVisibility(object sender, EventArgs e)
    {
        ActivityLimitIsVisible = !ActivityLimitIsVisible;
        OnPropertyChanged(nameof(ActivityLimitIsVisible));
    }

    private async void GoMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}