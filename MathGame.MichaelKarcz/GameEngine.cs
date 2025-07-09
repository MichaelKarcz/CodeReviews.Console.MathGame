﻿using MathGame.MichaelKarcz.Models;

namespace MathGame.MichaelKarcz
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {

            var difficulty = Helpers.SelectDifficulty();

            var random = new Random();


            int firstNumber;
            int secondNumber;

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message} - {difficulty}");

                int[] numbers = Helpers.GetNumbers(difficulty);

                firstNumber = numbers[0];
                secondNumber = numbers[1];

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your score was: {score}. Press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, difficulty, GameType.Addition);
        }


        internal void SubtractionGame(string message)
        {
            var difficulty = Helpers.SelectDifficulty();

            var random = new Random();


            int firstNumber;
            int secondNumber;

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message} - {difficulty}");

                int[] numbers = Helpers.GetNumbers(difficulty);

                firstNumber = numbers[0];
                secondNumber = numbers[1];

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your score was: {score}. Press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, difficulty, GameType.Subtraction);
        }


        internal void MultiplicationGame(string message)
        {
            var difficulty = Helpers.SelectDifficulty();

            var random = new Random();


            int firstNumber;
            int secondNumber;

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message} - {difficulty}");

                int[] numbers = Helpers.GetNumbers(difficulty);

                firstNumber = numbers[0];
                secondNumber = numbers[1];

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your score was: {score}. Press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, difficulty, GameType.Multiplication);
        }


        internal void DivisionGame(string message)
        {
            var difficulty = Helpers.SelectDifficulty();

            int firstNumber;
            int secondNumber;

            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{message} - {difficulty}");

                var divisionNumbers = Helpers.GetDivisionNumbers(difficulty);
                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over! Your score was: {score}. Press any key to return to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, difficulty, GameType.Division);
        }
    }
}
