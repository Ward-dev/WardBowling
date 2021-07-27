using System;

namespace WardBowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            int currentFrame = 1;
            int currentThrow = 1;
            do
            {
                Console.WriteLine($"Frame {currentFrame}");
                Console.WriteLine($"How many pins have you knocked over on throw {currentThrow}?");
                if (int.TryParse(Console.ReadLine(), out int pins))
                {
                    if (pins < 11 && pins >= 0)
                    {
                        if (pins == 10)
                        {
                            game.Throw(pins);
                            if (currentFrame == 10 && currentThrow < 3)
                            {
                                currentThrow++;
                            }
                            else
                            {
                                currentFrame++;
                            }
                        }
                        else
                        {
                            game.Throw(pins);
                            if (currentThrow == 2)
                            {
                                currentThrow = 1;
                                currentFrame++;
                            }
                            else
                            {
                                if (currentFrame == 10 && currentThrow == 3)
                                {
                                    currentFrame++;
                                }
                                currentThrow++;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Amount of pins needs to be a number between 0 and 10");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Amount of pins should be a number.");
                    Console.ReadLine();
                }

                Console.Clear();
            } while (currentFrame <= 10);

            Console.WriteLine($"Your total score for this game is {game.CalculateTotalScore()}");
            Console.ReadLine();

        }
    }
}
