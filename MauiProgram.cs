using MauiTry.Models;
using MauiTry.Services;
using MauiTry.ViewModels;
using MauiTry.Views;

namespace MauiTry;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<FirstPage>();
        builder.Services.AddTransient<FirstPageViewModel>();
        builder.Services.AddTransient<SecondPage>();
        builder.Services.AddTransient<SecondPageViewModel>();
        builder.Services.AddTransient<Lottery>();
        builder.Services.AddTransient<SecondPageViewModel>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<IDataService, DataService>();

        return builder.Build();
	}
}
