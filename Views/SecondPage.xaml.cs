using MauiTry.ViewModels;

namespace MauiTry.Views;

public partial class SecondPage : ContentPage
{
    //使用するクラスを外部から渡す(Dependency Injection)
    public SecondPage(SecondPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel; //ViewModel を割り当てる
    }
}