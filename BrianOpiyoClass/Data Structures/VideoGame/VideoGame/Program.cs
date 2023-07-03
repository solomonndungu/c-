namespace VideoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup objects
            VideoGames game1 = new VideoGames("PC", "World of Warcraft", "Blizzard", "Teen");

            // anonymous object type. No need of calling the class
            // We can change content of the keys to whatever we like because it is an anonymous type.
            var gameAnon = new { Console = "PC", Gamffe = "League of Legends", Publisher = "Riot Games", Rating = "Teen" };

            Console.WriteLine(gameAnon.Gamffe);

            // When creating an anonymous type, we create read only

            // Can create an array (Cascade) of anonymous type
            var animal = new { Name = "Henry", Species = new { Name = "Dog", Noise = "Bark" } };

            Console.WriteLine(animal.Species.Name);
        }
    }
}