using CommunityToolkit.Maui.Views;
using SquareSixMovies.Models;
using SquareSixMovies.ViewModels;

namespace SquareSixMovies.Views;

public partial class MovieDetailsPage : Popup
{
	public MovieDetailsPage(MovieDetails movieDetails, INavigationService navigationService)
	{
		InitializeComponent();
		BindingContext = new MovieDetailsPageViewModel(movieDetails, this, navigationService);
	}
}
