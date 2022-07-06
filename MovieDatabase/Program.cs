using MovieDatabase;
using Validator;

List<Movie> Movies = new List<Movie>()
{
    new Movie("Jaws", "Horror", 1975),
    new Movie("Friday the 13th", "Horror", 1980),
    new Movie("Spirited Away", "Animated", 2001),
    new Movie("Shrek", "Animated", 2001),
    new Movie("Shrek 2", "Animated", 2004),
    new Movie("Shrek the Third", "Animated", 2007),
    new Movie("Hidden Figures", "Drama", 2016),
    new Movie("Boys Don't Cry", "Drama", 1999),
    new Movie("Star Wars: A New Hope", "Scifi", 1977),
    new Movie("Spaceballs", "Scifi", 1987),

};

bool runProgram = true;

while(runProgram == true)
{
    string userCategory = "";

    //Get input and loop to get it again if invalid.
    while (true)
    {
        Console.WriteLine("Enter a category of movie: Animated, Drama, Horror, or Scifi.");
        userCategory = Console.ReadLine().Trim();
        if (userCategory != "Animated" && userCategory != "Drama" && userCategory != "Horror" && userCategory != "Scifi")
        {
            Console.WriteLine("Please enter a valid category.");
        }
        else
        {
            break;
        }
    }
    
    //loop over movies, alphabetized
    foreach (Movie movie in Movies.OrderBy(x => x.Title).ToList())
    {
        if (movie.Category == userCategory)
        {
            Console.WriteLine($"{movie.Title} ({movie.Year})");
        }
    }

    //Loop over program
    runProgram = Validator.Validator.GetContinue("Would you like to continue?");
}
