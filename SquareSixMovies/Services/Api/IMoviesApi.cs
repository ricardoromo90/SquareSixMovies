using System;
using Refit;
using System.Threading.Tasks;
using SquareSixMovies.Helpers;
using SquareSixMovies.DTOs;

namespace SquareSixMovies.Services.Api
{
	public interface IMoviesApi
	{
		[Get(EndpointDefinitions.DiscoverUrl)]
		public Task<MoviesResponse> GetMoviesAsync([AliasAs("page")] int page, [AliasAs("sort_by")] string sort = "popularity.desc", [AliasAs("api_key")] string apyKey = Constants.ApiKey);

		[Get(EndpointDefinitions.MovieDetailsUrl)]
		public Task<MovieDetailsDto> GetMovieDetailsAsync([AliasAs("id")] int id, [AliasAs("api_key")] string apyKey = Constants.ApiKey);
	}
}

