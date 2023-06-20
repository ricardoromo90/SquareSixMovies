using System;
using AutoMapper;
using SquareSixMovies.DTOs;
using SquareSixMovies.Models;

namespace SquareSixMovies.Helpers
{
	public static class AppBootstrapper
	{
		public static IMapper CreateMapper()
		{
			var mapperConfiguration = new MapperConfiguration(cfg => {
				cfg.CreateMap<MoviesResponse, Movies>();
				cfg.CreateMap<MovieDto, Movie>();
				cfg.CreateMap<MovieDetailsDto, MovieDetails>();
			});
			return mapperConfiguration.CreateMapper();
		}
	}
}

