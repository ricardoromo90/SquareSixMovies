using System;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using SquareSixMovies.Models;

namespace SquareSixMovies.ViewModels
{
	public partial class MovieDetailsPageViewModel : BasePageViewModel
	{
		public MovieDetailsPageViewModel(
			MovieDetails movie,
			Popup popup,
			INavigationService navigationService) : base(navigationService)
		{
			Movie = movie;
			MovieDetails = popup;

			RateValue = (int)(Movie.VoteAverage * 50) / 100;

			PageWidth = App.Current.MainPage.Width - 10;
			PageHeight = App.Current.MainPage.Height - 80;
		}

		public override void Initialize(INavigationParameters parameters)
		{
			base.Initialize(parameters);
		}

		public Popup MovieDetails { get; set; }

		public MovieDetails Movie { get; set; }

		public double PageWidth { get; set; }

		public double PageHeight { get; set; }

		public int RateValue { get; set; }

		[RelayCommand]
		public void ClosePoup()
		{
			MovieDetails.Close();
		}

		[RelayCommand]
		public async Task ViewTrailerAsync()
		{
			//Test Video
			await Browser.OpenAsync("https://storage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4", BrowserLaunchMode.SystemPreferred);
		}
	}
}

