using System;
namespace SquareSixMovies.Helpers
{
	public static class EndpointDefinitions
	{
		public const string BaseUrl = "https://api.themoviedb.org/3";
		public const string BaseImageUrl = "https://image.tmdb.org/t/p/w500";
		public const string BaseMovieDetailsUrl = $"{BaseUrl}/movie";
		public const string DiscoverUrl = "/discover/movie";
		public const string MovieDetailsUrl = "/movie/{id}";
	}
}