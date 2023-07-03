using System;
namespace VideoGame
{
	public class VideoGames
	{
		private string console;
		private string title;
		private string publisher;
		private string rating; // ONLY ALLOWED Ratings: E, 10+, Teen, Mature 17+, Adults Only 18+, Rating Pending

		// Same name as class it is contained in. Allow the programmer to set default values, limit instantiation,
		// and write code that is flexible and easy to read.
		public VideoGames(string console, string title, string publisher, string rating)
		{
			this.title = title;
			this.console = console;
			this.publisher = publisher;
			this.rating = rating;
		}

		public string GetRating()
		{
			return rating;
		}

		public string Rating
		{
			get { return rating; }
			set { rating = value; }
		}

		// Coz anonymous type is read only. This is what is generated behind the scenes. Read-only properties.
		public VideoGameRatingType Title
		{
			get;
		}

		public VideoGameRatingType Publisher
		{
			get;
		}

		public VideoGameRatingType Rating
		{

		}
	}
}

