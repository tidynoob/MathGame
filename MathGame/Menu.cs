
namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string? name, DateTime date)
        {

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date.ToShortDateString()}. This is your math game.\n");

            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
            V - View previous games
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            Q - Quit the program");
                Console.WriteLine("------------------------------------");

                string? selection = Helpers.GetSelection();

                switch (selection)
                {
                    case "v":
                        Console.Clear();
                        Helpers.PrintGames();
                        break;
                    case "a":
                        Console.Clear();
                        gameEngine.AdditionGame("Addition game selected");
                        break;
                    case "s":
                        Console.Clear();
                        gameEngine.SubtractionGame("Subtraction game selected");
                        break;
                    case "m":
                        Console.Clear();
                        gameEngine.MultiplicationGame("Multiplication game selected");
                        break;
                    case "d":
                        Console.Clear();
                        gameEngine.DivisionGame("Division game selected");
                        break;
                    case "q":
                        keepPlaying = false;
                        break;
                }
            }

            Console.WriteLine("Exiting the game");
            Environment.Exit(0);
        }
    }
}
