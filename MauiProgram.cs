using MauiTry.Models;
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
        builder.Services.AddTransient<FirstPageView>();
        builder.Services.AddTransient<FirstPageViewModel>();
        builder.Services.AddTransient<Person>();
        return builder.Build();
	}
}
