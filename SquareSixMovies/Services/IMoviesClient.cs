using System;
using SquareSixMovies.DTOs;

namespace SquareSixMovies.Services
{
	public interface IMoviesClient
	{
		Task<MoviesResponse> GetMoviesAsync(int page);
		Task<MovieDetailsDto> GetMovieDetailsAsync(int id);
	}
}

