using System;
using SquareSixMovies.Models;

namespace SquareSixMovies.Services
{
	public interface IMoviesService
	{
		Task<Movies> GetMoviesAsync(int page);
		Task<MovieDetails> GetMovieDetailsAsync(int id);
	}
}

