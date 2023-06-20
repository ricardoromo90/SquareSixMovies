using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareSixMovies.DTOs
{
	public class MovieDetailsDto
	{
		[JsonPropertyName("adult")]
		public bool Adult { get; set; }

		[JsonPropertyName("backdrop_path")]
		public string BackdropPath { get; set; }

		[JsonPropertyName("belongs_to_collection")]
		public BelongsToCollectionDto BelongsToCollection { get; set; }

		[JsonPropertyName("budget")]
		public int Budget { get; set; }

		[JsonPropertyName("genres")]
		public List<GenreDto> Genres { get; set; }

		[JsonPropertyName("homepage")]
		public string Homepage { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("imdb_id")]
		public string ImdbId { get; set; }

		[JsonPropertyName("original_language")]
		public string OriginalLanguage { get; set; }

		[JsonPropertyName("original_title")]
		public string OriginalTitle { get; set; }

		[JsonPropertyName("overview")]
		public string Overview { get; set; }

		[JsonPropertyName("popularity")]
		public double Popularity { get; set; }

		[JsonPropertyName("poster_path")]
		public string PosterPath { get; set; }

		[JsonPropertyName("production_companies")]
		public List<ProductionCompanyDto> ProductionCompanies { get; set; }

		[JsonPropertyName("production_countries")]
		public List<ProductionCountryDto> ProductionCountries { get; set; }

		[JsonPropertyName("release_date")]
		public string ReleaseDate { get; set; }

		[JsonPropertyName("revenue")]
		public double Revenue { get; set; }

		[JsonPropertyName("runtime")]
		public int Runtime { get; set; }

		[JsonPropertyName("spoken_languages")]
		public List<SpokenLanguageDto> SpokenLanguages { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("tagline")]
		public string Tagline { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

		[JsonPropertyName("video")]
		public bool Video { get; set; }

		[JsonPropertyName("vote_average")]
		public double VoteAverage { get; set; }

		[JsonPropertyName("vote_count")]
		public int VoteCount { get; set; }
	}

	public class BelongsToCollectionDto
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("poster_path")]
		public string PosterPath { get; set; }

		[JsonPropertyName("backdrop_path")]
		public string BackdropPath { get; set; }
	}

	public class GenreDto
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}

	public class ProductionCompanyDto
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("logo_path")]
		public string LogoPath { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("origin_country")]
		public string OriginCountry { get; set; }
	}

	public class ProductionCountryDto
	{
		[JsonPropertyName("iso_3166_1")]
		public string Iso31661 { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}

	public class SpokenLanguageDto
	{
		[JsonPropertyName("english_name")]
		public string EnglishName { get; set; }

		[JsonPropertyName("iso_639_1")]
		public string Iso6391 { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}
}

