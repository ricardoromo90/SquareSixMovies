using AutoMapper;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SquareSixMovies.Helpers;
using SquareSixMovies.Services;
using SquareSixMovies.ViewModels;
using SquareSixMovies.Views.Pages;

namespace SquareSixMovies;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder.UseMauiApp<App>();
		builder.UseMauiCommunityToolkit();
		builder.RegisterAppServices();
		builder.RegisterViewModels();
		builder.RegisterViews();
		builder.RegisterPrism();
		builder.ConfigureEffects(
			effects => {
			});
		builder.ConfigureEssentials(
			essentials => {
			});
		builder.ConfigureFonts(fonts => {
			fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
			fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
			fonts.AddFont("Rift-DemiItalic.ttf", "RiftItalic");

		});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	public static MauiAppBuilder RegisterPrism(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.UsePrism(prism =>
			prism.RegisterTypes(container => {
				container.RegisterForNavigation<NavigationPage>(nameof(NavigationPage));
				container.RegisterForNavigation<MainPage, MainPageViewModel>(nameof(MainPage));
			})
			.OnAppStart($"{nameof(NavigationPage)}/{nameof(MainPage)}"));
		return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddSingleton(typeof(IMapper), AppBootstrapper.CreateMapper());
		mauiAppBuilder.Services.AddSingleton<IMoviesService, MoviesService>();
		mauiAppBuilder.Services.AddSingleton<IMoviesClient, MoviesClient>();
		return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddTransient<MainPageViewModel>();
		return mauiAppBuilder;
	}

	public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
	{
		mauiAppBuilder.Services.AddTransient<MainPage>();
		return mauiAppBuilder;
	}
}