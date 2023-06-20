using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using SquareSixMovies.Services;
using SquareSixMovies.Models;
using SquareSixMovies.Views;

namespace SquareSixMovies.ViewModels
{
	public partial class MainPageViewModel : BasePageViewModel
	{
		private readonly IMoviesService _moviesService;
		public MainPageViewModel(
			INavigationService navigationService,
			IMoviesService moviesService) : base(navigationService)
		{
			_moviesService = moviesService;
		}

		public override async void Initialize(INavigationParameters parameters)
		{
			base.Initialize(parameters);
			await GetMoviesAsync();
		}

		[ObservableProperty]
		public string title;

		[ObservableProperty]
		public bool isRefreshing;

		[ObservableProperty]
		private ObservableCollection<CategoryMovies> movies;

		[RelayCommand]
		public async Task RefreshViewAsync()
		{
			try {
				IsRefreshing = true;
				Movies.Clear();
				await GetMoviesAsync();
			} finally {
				IsRefreshing = false;
			}
		}

		[RelayCommand]
		public async Task MovieSelectedAsync(Movie movie)
		{
			var movieDetails = await _moviesService.GetMovieDetailsAsync(movie.Id);
			var popup = new MovieDetailsPage(movieDetails, NavigationService);
			App.Current.MainPage.ShowPopup(popup);
		}

		private async Task GetMoviesAsync()
		{
			var moviesResultPage1 =  _moviesService.GetMoviesAsync(1);
			var moviesResultPage2 =  _moviesService.GetMoviesAsync(2);
			var moviesResultPage3 =  _moviesService.GetMoviesAsync(3);
			var moviesResultPage4 =  _moviesService.GetMoviesAsync(4);

			await Task.WhenAll(moviesResultPage1, moviesResultPage2, moviesResultPage3, moviesResultPage4);

			Movies = new()
			{
				new()
				{
					Category = "Popular",
					Movies = moviesResultPage1.Result.Results,
				},
				new()
				{
					Category = "Action",
					Movies = moviesResultPage2.Result.Results,
				},
				new()
				{
					Category = "Comedy",
					Movies = moviesResultPage3.Result.Results,
				},
				new()
				{
					Category = "Action",
					Movies = moviesResultPage4.Result.Results,
				}
			};
		}
	}
}

