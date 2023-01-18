using Chasipanta_SimulacroExamen.Views;

namespace Chasipanta_SimulacroExamen;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPage), typeof(BurgerItemPage));
    }
}
