using chapter_2.Methods;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace chapter_2
{
    public static class Program
    {

        static void Main(string[] args)
        {
            bool wholeGame = true;
            while (wholeGame)
            {
                string str = "";
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(str.Wel());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(str.Info());
                string difficulty = "";
                bool hardOrnot = false;
                bool whileDef = true;
                while (whileDef)
                {
                    difficulty = Console.ReadLine();
                    whileDef = Chapter2.ChooseDef(difficulty, out string answerFromMethod, out bool hardOrNot1);
                    Console.WriteLine(answerFromMethod);
                    hardOrnot = hardOrNot1;
                }
                Console.WriteLine("\n" + str.StartMessage() + "\n\n");
                int a = 0;
                int myRandomizedNum = Chapter2.Randomize(a, hardOrnot);
                int chance = Chapter2.ChanceValue(hardOrnot);
                string _status = "";
                Stopwatch stopwatch = new Stopwatch();
                int abstractChance = 0;
                stopwatch.Start();
                while (chance != 0)
                {
                    
                    string helpReq = "";
                    bool enteredNumBool = int.TryParse(Console.ReadLine(), out int enteredNum);
                    if (!enteredNumBool)
                    {
                        Console.WriteLine("Please try again");
                        continue;
                    }
                    if (abstractChance == 6)
                    {
                        Console.WriteLine("Want some help? Y/N");
                        helpReq = Console.ReadLine();
                    }
                    if (helpReq == "y" || helpReq == "Y")
                    {
                        abstractChance = 0;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(Chapter2.HelpMethod(myRandomizedNum));
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        helpReq = "";
                        abstractChance = 0;
                        continue;
                    }
                        string answerFromMethod = Chapter2.Compare(enteredNum, myRandomizedNum, ref chance, out string status);
                        _status = Chapter2.SuccessfulOrNot(status);
                        Console.Write(answerFromMethod);
                        if (chance != 0)
                            Console.WriteLine("  Chance Left : {0}", chance);
                    abstractChance = chance;

                    }
                    stopwatch.Stop();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n" + Chapter2.Status(stopwatch.ElapsedMilliseconds / 1000, _status));

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nClose the window or press Alt + F4 if you dont want to play again.\n\nIf you will to play again just press a key !!");













                    Console.ReadKey();



                }

            }
        }
    }
