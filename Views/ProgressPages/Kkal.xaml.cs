using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace FitnessApp.Views.ProgressPages;

public partial class Kkal : ContentPage
{
    public bool InputKkalIsVisible { get; set; } = false;
    public ObservableCollection<FoodItem> FoodItems { get; set; }
    public Command RemoveCommand { get; }

    public Kkal()
    {
        InitializeComponent();
        FoodItems = new ObservableCollection<FoodItem>();
        RemoveCommand = new Command(OnRemove);
        BindingContext = this;
    }

    private void OnRemove(object obj)
    {
        if (obj is FoodItem item)
        {
            FoodItems.Remove(item);
        }
    }

    private void ToggleInputVisibility(object sender, EventArgs e)
    {
        InputKkalIsVisible = !InputKkalIsVisible;
        OnPropertyChanged(nameof(InputKkalIsVisible));
    }

    private async void AddFood_Clicked(object sender, EventArgs e)
    {
        if (!double.TryParse(Weight.Text, out double weight) ||
            !double.TryParse(KkalIn.Text, out double kkalPer100g) ||
            !double.TryParse(Proteins.Text, out double proteins) ||
            !double.TryParse(Fats.Text, out double fats) ||
            !double.TryParse(Carbohydrates.Text, out double carbs))
        {
            await DisplayAlert("Ошибка", "Введите корректные числа", "OK");
            return;
        }

        var newItem = new FoodItem
        {
            Name = WhatDoYouEat.Text ?? "Неизвестно",
            ImageUrl = "food_ex.jpg",
            Weight = (int)weight,
            Calories = (int)(kkalPer100g * weight / 100),
            Protein = (int)(proteins * weight / 100),
            Fat = (int)(fats * weight / 100),
            Carbs = (int)(carbs * weight / 100),
            Date = DateTime.Now.Date,
            Time = DateTime.Now.TimeOfDay
        };

        FoodItems.Add(newItem);
        ToggleInputVisibility(null, null); // Скрыть попап
    }

    private async void GoMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}

public class FoodItem
{
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    public int Calories { get; set; }
    public int Weight { get; set; }
    public double Fat { get; set; }
    public double Protein { get; set; }
    public double Carbs { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
}