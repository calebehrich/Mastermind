﻿using System;
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
                }
            }

            userNumber.RemoveRange(0, 4);
        }
    }
}
