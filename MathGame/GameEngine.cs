
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Random random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                int answer = int.Parse(Console.ReadLine());

                if (answer == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}! Enter to continue.");
            Console.ReadKey();
            Console.Clear();

            Helpers.AddToHistory(score, GameType.Addition);


        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);
            Random random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                int answer = int.Parse(Console.ReadLine());

                if (answer == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}! Enter to continue.");
            Console.ReadKey();
            Console.Clear();

            Helpers.AddToHistory(score, GameType.Subtraction);

        }

        internal void MultiplicationGame(string message)
        {
            Random random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} * {secondNumber}");
                int answer = int.Parse(Console.ReadLine());

                if (answer == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}! Enter to continue.");
            Console.ReadKey();
            Console.Clear();

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            Console.WriteLine(message);
            int score = 0;

            for (int i = 0; i < 5; i++)
            {

                int[] numbers = Helpers.GetDivisionNumbers();
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                Console.Clear();
                Console.WriteLine(message);
                Console.WriteLine($"{firstNumber} / {secondNumber}");
                int answer = int.Parse(Console.ReadLine());

                if (answer == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect.");
                }
            }

            Console.WriteLine($"Game over. Your final score is {score}! Enter to continue.");
            Console.ReadKey();
            Console.Clear();

            Helpers.AddToHistory(score, GameType.Division);


        }
    }
}
