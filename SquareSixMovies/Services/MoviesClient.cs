using System;
using Refit;
using SquareSixMovies.DTOs;
using SquareSixMovies.Helpers;
using SquareSixMovies.Services.Api;

namespace SquareSixMovies.Services
{
	public class MoviesClient : IMoviesClient
	{
		private readonly IMoviesApi _moviesApi;

		public MoviesClient()
		{
			var client = new HttpClient() { BaseAddress = new Uri(EndpointDefinitions.BaseUrl) };
			_moviesApi = RestService.For<IMoviesApi>(client);
		}

		public Task<MovieDetailsDto> GetMovieDetailsAsync(int id)
			=> _moviesApi.GetMovieDetailsAsync(id);

		public Task<MoviesResponse> GetMoviesAsync(int page)
			=> _moviesApi.GetMoviesAsync(page);
	}
}

