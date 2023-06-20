using System;
using System.Text.Json.Serialization;

namespace SquareSixMovies.DTOs
{
	public class MoviesResponse
	{
		[JsonPropertyName("page")]
		public int Page { get; set; }

		[JsonPropertyName("results")]
		public List<MovieDto> Results { get; set; }

		[JsonPropertyName("total_pages")]
		public int TotalPages { get; set; }

		[JsonPropertyName("total_results")]
		public int TotalResults { get; set; }
	}
}

