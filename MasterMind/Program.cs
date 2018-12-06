using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static Random rnd = new Random();
        static List<int> winningNumber = new List<int> { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) };
        static List<int> userNumber = new List<int> { };
        static int correctNumbers = 0;
            

        static void Main(string[] args)
        {
            Program p = new Program();
            int userAttempts = 1;
            bool isComplete = false;

            do
            {
                p.GetGuess();
                Console.WriteLine("\n");
                p.Compare(winningNumber, userNumber);
                Console.WriteLine("\n");
                if (correctNumbers == 4)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("You guessed the right number. YOU WIN!!");
                    isComplete = true;
                }
                if (userAttempts == 10)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("You did not guess the number correctly. Better luck next time.");
                    Console.Write("The winning number was: ");
                    foreach(int i in winningNumber)
                    {
                        Console.Write(i);                       
                    }
                    Console.WriteLine("\n");
                    isComplete = true;
                }
                userAttempts++;
                correctNumbers = 0;
            } while (isComplete == false && userAttempts <= 10);
        }

        public void GetGuess()
        {
            Console.WriteLine("Please enter four numbers between 1-6");
            int userGuess = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                userNumber.Insert(0, userGuess % 10);
                userGuess /= 10;
            }

        }

        public void Compare(List<int> winningNumber, List<int> userNumber)
        {

            for (int i = 0; i < winningNumber.Count; i++)
            {
                if (winningNumber[i] == userNumber[i])
                {
                    Console.Write("+ ");
                    userNumber[i] = 0;
                    correctNumbers++;
                }
            }
            for (int i = 0; i < winningNumber.Count; i++)
            {
                if (winningNumber.Contains(userNumber[i]))
                {
                    Console.Write("- ");
                    userNumber[i] = 0;
                }
            }

            userNumber.RemoveRange(0, 4);
        }
    }
}
