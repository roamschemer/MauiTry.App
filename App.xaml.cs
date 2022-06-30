using MauiTry.Views;

namespace MauiTry;

public partial class App : Application
{
	public App(FirstPage pageView)
	{
		InitializeComponent();
		MainPage = new NavigationPage(pageView);
	}
}
