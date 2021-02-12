using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Movie
    {
		public Movie(string title, string category)
		{
			_title = title;
			_category = category;
		}
		public Movie()
		{

		}

		private string _category;
		private string _title;

		public void GetAnimated()
		{
			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if (movie._category == "Animated")
				{
					Console.WriteLine(movie._title);
				}
			}
		}

		private List<Movie> InitializeList()
		{
			var movielist = new List<Movie>();
			movielist.Add(new Movie("Spirited Away", "Animated"));
			movielist.Add(new Movie("Frozen", "Animated"));
			movielist.Add(new Movie("Rambo", "Action"));
			movielist.Add(new Movie("Django", "Action"));

			return movielist;
		}

	}
}

