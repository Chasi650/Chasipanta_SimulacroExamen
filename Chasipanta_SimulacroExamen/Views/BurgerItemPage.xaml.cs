using Chasipanta_SimulacroExamen.Data;
using Chasipanta_SimulacroExamen.Models;

namespace Chasipanta_SimulacroExamen.Views;

[QueryProperty("Item", "Item")]

public partial class BurgerItemPage : ContentPage
{
    public HamburguesaPCh Item
    {
        get => BindingContext as HamburguesaPCh;
        set => BindingContext = value;
    }

    public BurgerItemPage()
	{
		InitializeComponent();
        BindingContext = Item;
    }

	private void OnSaveClicked(object sender, EventArgs e)
	{
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChanged(object sender,CheckedChangedEventArgs e)
    {
        
    }

    private void OnDeletedClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.DeleteItem(Item);
        Shell.Current.GoToAsync("..");
    }
}