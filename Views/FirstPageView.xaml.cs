using MauiTry.Models;
using MauiTry.ViewModels;

namespace MauiTry.Views;

public partial class FirstPageView : ContentPage
{
	public FirstPageView(FirstPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}