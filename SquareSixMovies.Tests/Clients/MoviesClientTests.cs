using System;
using Moq;
using SquareSixMovies.Services;

namespace SquareSixMovies.Tests.Clients
{
	public class MoviesClientTests
	{
		public MoviesClientTests()
		{
		}

		private async Task<MoviesClient> Client()
		{
			return new MoviesClient();
		}

		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(3)]
		public async Task GetMoviesAsync(int page)
		{
			var client = await Client();
			var movies = await client.GetMoviesAsync(page);
			Assert.NotNull(movies);
		}

		[Theory]
		[InlineData(1)]
		public async Task GetMovieDetailsAsync(int page)
		{
			var client = await Client();
			var movies = await client.GetMoviesAsync(page);
			if (movies == null)
			{
				return;
			}
			var movieDetails = await client.GetMovieDetailsAsync(movies.Results[0].Id);
			Assert.NotNull(movies);
		}
	}
}

