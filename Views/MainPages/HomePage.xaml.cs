using System.Collections.ObjectModel;
namespace FitnessApp.Views.MainPages;

public partial class HomePage : ContentPage
{
    private DayModel _selectedDay;

    public DayModel SelectedDay
    {
        get => _selectedDay;
        set
        {
            if (_selectedDay != value)
            {
                _selectedDay = value;
                OnPropertyChanged(nameof(SelectedDay));
            }
        }
    }
    public ObservableCollection<DayModel> Days { get; set; } = new();
    private int weekOffset = 0;
    public HomePage()
    {
        InitializeComponent();
        GenerateCalendar();
    }

    private void GenerateCalendar()
    {
        Days.Clear();

        DateTime today = DateTime.Today;
        DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek + (today.DayOfWeek == DayOfWeek.Sunday ? -6 : 1)).AddDays(weekOffset * 7);

        for (int i = 0; i < 7; i++)
        {
            DateTime day = startOfWeek.AddDays(i);

            Days.Add(new DayModel
            {
                Day = day.Day.ToString(),
                DayOfWeek = GetDayOfWeekShort(day.DayOfWeek)
            });
        }

        BindingContext = null;
        BindingContext = this;
    }

    private string GetDayOfWeekShort(DayOfWeek dayOfWeek)
    {
        return dayOfWeek switch
        {
            DayOfWeek.Monday => "ПН",
            DayOfWeek.Tuesday => "ВТ",
            DayOfWeek.Wednesday => "СР",
            DayOfWeek.Thursday => "ЧТ",
            DayOfWeek.Friday => "ПТ",
            DayOfWeek.Saturday => "СБ",
            DayOfWeek.Sunday => "ВС",
            _ => ""
        };
    }

    private void OnPreviousWeekClicked(object sender, EventArgs e)
    {
        weekOffset--;
        GenerateCalendar();
    }

    private void OnNextWeekClicked(object sender, EventArgs e)
    {
        weekOffset++;
        GenerateCalendar();
    }
}

public class DayModel
{
    public string Day { get; set; }
    public string DayOfWeek { get; set; }
    public bool IsSelected { get; set; }
}
