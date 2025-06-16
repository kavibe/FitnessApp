namespace FitnessApp.Views.ProgressPages;

public partial class WaterPage : ContentPage
{
    public bool AddWaterIsVisible { get; set; } = false;
    public bool AddWaterLimitIsVisible { get; set; } = false;
    //public static bool DimmigIsVisible { get; set; } = ToggleDimmingVisibility(AddWaterIsVisible, AddWaterLimitIsVisible);

    public WaterPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

    public void ToggleAddWaterVisibility(object sender, EventArgs e)
    {
        AddWaterIsVisible = !AddWaterIsVisible;
        OnPropertyChanged(nameof(AddWaterIsVisible));
    }

    public void ToggleAddWaterLimitVisibility(object sender, EventArgs e)
    {
        AddWaterLimitIsVisible = !AddWaterLimitIsVisible;
        OnPropertyChanged(nameof(AddWaterLimitIsVisible));
    }

    public static bool ToggleDimmingVisibility(bool AddWaterIsVisible, bool AddWaterLimitIsVisible)
    {
        return AddWaterIsVisible || AddWaterLimitIsVisible;
    }

    private async void GoMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}