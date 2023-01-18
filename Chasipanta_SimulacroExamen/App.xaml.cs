using Chasipanta_SimulacroExamen.Data;
using Chasipanta_SimulacroExamen.Views;

namespace Chasipanta_SimulacroExamen;

public partial class App : Application
{
	public static BurgerDatabase BurgerRepo { get; set; }	
	
	public App(BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		BurgerRepo = repo;
	}
}
