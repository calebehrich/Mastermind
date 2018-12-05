using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static List<int> userNumber = new List<int> { };


        static void Main(string[] args)
        {
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
    }
}
