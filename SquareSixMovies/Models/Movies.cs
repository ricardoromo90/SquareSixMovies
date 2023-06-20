using System;
using System.Collections.Generic;

namespace SquareSixMovies.Models
{
	public class Movies
	{
		public int Page { get; set; }
		public List<Movie> Results { get; set; }
		public int TotalPages { get; set; }
		public int TotalResults { get; set; }
	}
}

