using Chasipanta_SimulacroExamen.Data;
using Chasipanta_SimulacroExamen.Models;

namespace Chasipanta_SimulacroExamen.Views;

public partial class BurgerItemPage : ContentPage
{
    HamburguesaPCh Item = new HamburguesaPCh();
    bool _flag;

    public BurgerItemPage()
	{
		InitializeComponent();
	}

	private void OnSaveClicked(object sender, EventArgs e)
	{
        Item.Name = nameB.Text;
        Item.Description = descB.Text;
        Item.WithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");

    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChanged(object sender,CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

}