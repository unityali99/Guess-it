using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_1
{
    class Program
    {



        static void Main(string[] args)

        {
            bool wholeGame = true;
            while (wholeGame)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Welcome to the challange. Can you guess what the number is ? :D");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Hard max number = 150 , Easy max number = 100\nWhich difficulty would you like to play ?  Easy 'E' Hard 'H' : ");
                string difficulty = "";
                bool while1 = true;
                while (while1)
                {
                    difficulty = Console.ReadLine();
                    if (difficulty == "E" || difficulty == "H" || difficulty == "e" || difficulty == "h")
                    {
                        while1 = false;
                    }
                    else
                        Console.WriteLine("Please try again");

                }

                bool hardOrNot = difficulty == "h" || difficulty == "H" ? true : false;
                string toShow = difficulty == "h" || difficulty == "H" ? "Hard" : "Easy";

                Console.ForegroundColor = hardOrNot ? ConsoleColor.Red : ConsoleColor.DarkGreen;

                Console.WriteLine($"\nYou chose {toShow} ! :]\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Here we start. You can exit the game at any time by pressing Alt+F4 \nCan you find the number ??\nEnter your numbers  ");
                byte randomize = (byte)(hardOrNot ? 150 : 100);
                Random rndm = new Random();
                byte myRandomNum = (byte)(rndm.Next(randomize));
                byte chance = (byte)(hardOrNot ? 10 : 14);
                int attemps = 0;
                string status = "Failure";
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                while (chance != 0)
                {
                    Console.WriteLine($"\n\nChance : {chance}");
                    byte thought;
                    if (chance == 5)
                    {
                        Console.WriteLine("Wanna help ? (Y/N)");
                        string helpOrNo = Console.ReadLine();

                        if (helpOrNo == "Y" || helpOrNo == "y")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("The last number of the answer is " + myRandomNum.ToString().Last());
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        Console.WriteLine("Resume entering numbers .......");


                    }
                    bool numberOrString = byte.TryParse(Console.ReadLine(), out thought);
                    if (!numberOrString)
                        Console.WriteLine("Please try again");

                    else if (myRandomNum > thought)
                    {
                        Console.WriteLine($"The answer is bigger than {thought}");
                        chance--;
                    }
                    else if (myRandomNum < thought)
                    {
                        Console.WriteLine($"The answer is less than {thought}");
                        chance--;
                    }


                    else if (myRandomNum == thought)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You Won !!");
                        chance--;
                        status = "successful";
                        break;
                    }



                    attemps++;

                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue . . . ");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine($"Your attemps : {attemps} --------------------- Your time : {(stopwatch.ElapsedMilliseconds / 1000).ToString()} Sec --------------------- status : {status}");
                Console.WriteLine();
                Console.WriteLine("Would you like to play again ? (Y/N)");
                string playAgain = Console.ReadLine();

                wholeGame = playAgain == "y" || playAgain == "Y" ? true : false;










            }



        }




















    }
}


