using MauiTry.Models;
using MauiTry.ViewModels;

namespace MauiTry.Views;

public partial class FirstPage : ContentPage
{
	public FirstPage(FirstPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}