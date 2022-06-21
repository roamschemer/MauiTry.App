using MauiTry.Views;
using MauiTry.Models;

namespace MauiTry;

public partial class App : Application
{
	public App(Person person)
	{
		InitializeComponent();
		MainPage = new FirstPageView(person);
	}
}
