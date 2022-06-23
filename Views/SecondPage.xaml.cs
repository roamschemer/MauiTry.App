using MauiTry.ViewModels;

namespace MauiTry.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}