using MauiTry.Views;
using MauiTry.Models;

namespace MauiTry;

public partial class App : Application
{
	public App(FirstPageView pageView)
	{
		InitializeComponent();
		MainPage = pageView;
	}
}
