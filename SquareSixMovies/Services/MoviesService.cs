using System;
using AutoMapper;
using SquareSixMovies.Models;

namespace SquareSixMovies.Services
{
	public class MoviesService : IMoviesService
	{
		private readonly IMoviesClient _moviesClient;
		private readonly IMapper _mapper;

		public MoviesService(
			IMoviesClient moviesClient,
			IMapper mapper)
		{
			_moviesClient = moviesClient;
			_mapper = mapper;
		}

		public async Task<MovieDetails> GetMovieDetailsAsync(int id)
		{
			var result = await _moviesClient.GetMovieDetailsAsync(id);
			return _mapper.Map<MovieDetails>(result);
		}

		public async Task<Movies> GetMoviesAsync(int page)
		{
			var result = await _moviesClient.GetMoviesAsync(page);
			return _mapper.Map<Movies>(result);
		}
	}
}

