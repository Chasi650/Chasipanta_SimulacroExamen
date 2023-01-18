namespace Chasipanta_SimulacroExamen.Views;
using Chasipanta_SimulacroExamen.Models;
using Chasipanta_SimulacroExamen.Data;

[QueryProperty("Item", "Item")]
public partial class BurguerListPage : ContentPage
{
	public BurguerListPage()
	{
		InitializeComponent();
        BindingContext = this;
        
    }
    private void OnUpdate(object sender, EventArgs e)
    {
        List<HamburguesaPCh> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
        
    public void OnItemAdded(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new  HamburguesaPCh()
        });
    }
    private void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        OnUpdate(sender, e);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<HamburguesaPCh> newBurgers = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
    }
    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        HamburguesaPCh burgers = e.CurrentSelection.FirstOrDefault() as HamburguesaPCh;
        if (burgers == null)
            return;
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            {"Item", burgers}

        });
        ((CollectionView)sender).SelectedItem = null;
    }
}