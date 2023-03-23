using Microsoft.AspNetCore.Components.WebView.Maui;
using MyBlaze.Data;
using MyBlaze.Services;

namespace MyBlaze;

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
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddScoped<ApiService>(x => new ApiService("https://localhost:7252/"));
		return builder.Build();
	}
}
