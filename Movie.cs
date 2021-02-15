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
                
				Console.WriteLine("Would you like to continue? (y/n)");
				var response = Console.ReadLine();

                if (response == "n")
                {
					break;
                }

			}
		}

		public void GetHorror()
		{
			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if (movie._category == "Horror")
				{
					Console.WriteLine(movie._title);
				}

				Console.WriteLine("Would you like to continue? (y/n)");
				var response = Console.ReadLine();

				if (response == "n")
				{
					break;
				}

			}
		}

		public void GetSciFi()
		{
			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if (movie._category.Equals("Sci Fi"));
				{
					Console.WriteLine(movie._title);
				}

				Console.WriteLine("Would you like to continue? (y/n)");
				var response = Console.ReadLine();

				if (response == "n")
				{
					break;
				}

			}
		}

		public void GetDrama()
		{
			var movielist = InitializeList();

			foreach (var movie in movielist)
			{
				if (movie._category == "Drama")
				{
					Console.WriteLine(movie._title);
				}

				Console.WriteLine("Would you like to continue? (y/n)");
				var response = Console.ReadLine();

				if (response == "n")
				{
					break;
				}

			}
		}



		private List<Movie> InitializeList()
		{
			var movielist = new List<Movie>();
			movielist.Add(new Movie("Spirited Away", "Animated"));
			movielist.Add(new Movie("Frozen", "Animated"));
			movielist.Add(new Movie("Star Trek", "Sci Fi"));
			movielist.Add(new Movie("I, Robot", "Sci Fi"));
			movielist.Add(new Movie("Lost in Translation", "Drama"));
			movielist.Add(new Movie("Little Women", "Drama"));
			movielist.Add(new Movie("Annabelle", "Horror"));
			movielist.Add(new Movie("Saw", "Horror"));


			return movielist;
		}

	}
}

