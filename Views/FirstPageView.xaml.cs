using MauiTry.Models;
using MauiTry.ViewModels;

namespace MauiTry.Views;

public partial class FirstPageView : ContentPage
{
	public FirstPageView(Person person)
	{
		InitializeComponent();
        BindingContext = new FirstPageViewModel(this.Navigation, person);
    }
}