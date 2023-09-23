using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        static List<Game> games = new List<Game>
        {
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Multiplication, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Division, Score = 1 }
        };

        internal static string? GetName()
        {
            Console.WriteLine("Please type your name");
            string? name = Console.ReadLine();
            return name;
        }

        internal static string GetSelection()
        {
            string? selection = Console.ReadLine().Trim().ToLower();

            while (selection == null || !"asmdqv".Contains(selection))
            {
                Console.WriteLine("Please enter a valid selection.\n");
                selection = Console.ReadLine().Trim().ToLower();
            }

            return selection;
        }


        internal static void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Type == GameType.Addition).ToList();

            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("------------------------------------");
            if (games.Count < 1)
            {
                Console.WriteLine("You have not played any games.");
            }
            else
            {
                foreach (var game in gamesToPrint)
                {
                    Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} Points");
                }
            }
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Enter to continue.");
            Console.ReadKey();
            Console.Clear();
        }


        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            int[] result = new int[2];



            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;
            return result;
        }

        internal static void AddToHistory(int score, GameType gameType)
        {
            //games.Add($"{DateTime.Now} - {gameType}: {score} Points");
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }
    }
}
