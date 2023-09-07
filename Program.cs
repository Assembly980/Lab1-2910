namespace Twitty_Brandon_Lab1_2910
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string file = folder + Path.DirectorySeparatorChar + "videogames.csv";

            List<VideoGame> games = new List<VideoGame>();

            using(var reader = new StreamReader(file))
            {
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] values = line.Split(',');

                    VideoGame x = new VideoGame()
                    {
                        Name = values[0],
                        Platform = values[1],
                        Year = values[2], 
                        Genre = values[3],
                        Publisher = values[4],
                        NA_Sales = values[5],
                        EU_Sales = values[6],
                        JP_Sales = values[7],
                        Other_Sales = values[8],
                        Global_Sales = values[9]
                    };

                    games.Add(x);
                }   //End of While Loop
            }  //End of Using statement 

            games.Sort();
            double numGames = games.Count();

            Console.WriteLine("What Publisher do you want to look at?");
            string userPublisher = Console.ReadLine();
            PublisherData(games, userPublisher);
            

            Console.WriteLine("\n\n\n\n\n\n");

            Console.WriteLine("What Genre do you want to look at?");
            string userGenre = Console.ReadLine();
            GenreData(games, userGenre);
            
            
        }

        static void PublisherData(List<VideoGame> games, string publisher)
        {
            var publisherGames = games.Where(x => x.Publisher == publisher);
            foreach (var pub in publisherGames) Console.WriteLine(pub.ToString());

            double numGames = games.Count();

            var ubisoftGames = games.Where(x => x.Publisher == publisher);
            double numPublisher = ubisoftGames.Count();
            double percentPublisher = Math.Round((numPublisher / numGames * 100), 2);
            Console.WriteLine($"Of the {numGames} games, {numPublisher} are by Ubisoft games, which is {percentPublisher}%");
        }

        static void GenreData(List<VideoGame> games, string genre)
        {
            var genreGames = games.Where(x => x.Genre == genre);
            foreach (var gen in genreGames) Console.WriteLine(gen.ToString());

            double numGames = games.Count();

            var Creeper_____Aww_Man = games.Where(X => X.Genre == genre);
            double NumGen = Creeper_____Aww_Man.Count();
            double percentGen = Math.Round((NumGen * 100 / numGames), 2);
            Console.WriteLine($"Of the {numGames} games, {NumGen} are Simulation games, which is {percentGen}%");
        }
    }
}