using MauiTry.ViewModels;

namespace MauiTry.Views;

public partial class SecondPage : ContentPage
{
    //�g�p����N���X���O������n��(Dependency Injection)
    public SecondPage(SecondPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel; //ViewModel �����蓖�Ă�
    }
}