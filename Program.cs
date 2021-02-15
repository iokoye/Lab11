using System;


namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();



            Console.WriteLine(GetUserInput());

        }
        public static string GetUserInput()
        {
            string response;
            do
            {
                Console.WriteLine("Welcome to the Movie List Application!" + "\r\n" + "There are 100 movies in this list." + "\r\n" +
              "What category are you interested in?");
                response = Console.ReadLine();

            } while (IsUserInputValid(response));

            return response;
        }
        public static bool IsUserInputValid(string response)
        {
            if (response == "Sci Fi")
            {
                var scifi = new Movie();
                scifi.GetSciFi();
            }           
            return true;
        }
    }
}
