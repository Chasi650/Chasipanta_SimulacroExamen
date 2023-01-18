namespace Chasipanta_SimulacroExamen.Views;
using Chasipanta_SimulacroExamen.Models;
using Chasipanta_SimulacroExamen.Data;

public partial class BurguerListPage : ContentPage
{
	public BurguerListPage()
	{
		InitializeComponent();
        List<HamburguesaPCh> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;

    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage));
    }
}