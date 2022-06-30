using MauiTry.Views;

namespace MauiTry;

public partial class App : Application
{
    //使用するクラスを外部から渡す(Dependency Injection)
    public App(FirstPage pageView)
	{
		InitializeComponent();
		MainPage = new NavigationPage(pageView); //最初のページを指定。今回は NavigationPage なのでこのような形になる。
        //MainPage = pageView; //単一ページでよければこれでよい。
    }
}
