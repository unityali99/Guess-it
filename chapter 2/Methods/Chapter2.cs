using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace chapter_2.Methods
{
    public static class Chapter2
    {




        /// <summary>
        /// Chooses the defficulty you chose
        /// </summary>
        /// <param name="difficulty"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool ChooseDef(string difficulty, out string a, out bool b)
        {
            bool hardOrNot = difficulty == "h" || difficulty == "H" || difficulty == "e" || difficulty == "E" ? false : true;

            b = false;

            if (difficulty == "h" || difficulty == "H")
            {
                a = "You Chose Hard !!";
                b = true;
            }
            else if (difficulty == "e" || difficulty == "E")
            {
                a = "You chose Easy !";
                b = false;
            }

            else
                a = "\nIncorrect input , Press a key then try again .";

            return hardOrNot;
        }
        /// <summary>
        /// Say Welcome
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Wel(this string a)
        {
            return "Welcome to the challange. Can you guess what the number is ? :D";
        }

        /// <summary>
        /// Difficulty helper
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string Info(this string a)
        {
            return "Hard max number = 150 , Easy max number = 100\nWhich difficulty would you like to play ?  Easy 'E' Hard 'H' : ";
        }

        public static string HelpMethod(int target)
        {
            return $"The last digit of the target is : {target.ToString().LastOrDefault()}";
        }

        /// <summary>
        /// Start the game by a message
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string StartMessage(this string a)
        {
            return "Here we start. You can exit the game at any time by pressing Alt + F4 \nCan you find the number ??\nEnter your numbers";
        }

        /// <summary>
        /// Selects the max number which is the target in game by your difficulty
        /// </summary>
        /// <param name="random"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static int MaxRandom(int random, bool def)
        {
            random = (def ? 150 : 100);
            return random;
        }

        /// <summary>
        /// Chooses our random number
        /// </summary>
        /// <param name="random"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        public static int Randomize(int random, bool def)
        {
            random = MaxRandom(random, def);
            Random rnd = new Random();
            return rnd.Next(random);
        }
        /// <summary>
        /// Selects the amount of chances
        /// </summary>
        /// <param name="def"></param>
        /// <returns></returns>
        public static int ChanceValue(bool def)
        {
            int chance = def ? 10 : 16;
            return chance;
        }
        /// <summary>
        /// Compares your number to the target
        /// </summary>
        /// <param name="enteredNum"></param>
        /// <param name="target"></param>
        /// <param name="chance"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string Compare(int enteredNum, int target, ref int chance, out string status)
        {
            status = "";
            if (enteredNum == target)
            {
                chance = 0;
                status = "Successful";
                return "You Won !!!";
            }
            else if (enteredNum > target)
            {
                chance--;
                return "The target is smaller than your guess !";
            }
            else
            {
                chance--;
                return "The target is bigger than your guess !";
            }

           
        }

        /// <summary>
        /// Returns the game's condition
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string SuccessfulOrNot(string status)
        {
            if (status == "Successful")
                return "Successful";
            else
                return "Failure";



            
        }
        /// <summary>
        /// Returns a text for the status
        /// </summary>
        /// <param name="time"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string Status(long time,string status)
        {
            return $"Status : {status} ------- Time Elapsed --> {time}";
        }
    }
}
