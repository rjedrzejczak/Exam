﻿using System;

namespace e54
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bValidInteger = false;
            int value = 0;
            do
            {
                Console.WriteLine("Enter an integer:");
                bValidInteger = GetValidInteger(ref value);
            } while (!bValidInteger);
            Console.WriteLine("You entered a valid integer, " + value);

            
        }

        private static bool GetValidInteger(ref int val)
        {
            string sLine = Console.ReadLine();
            int number;
            
            if (!int.TryParse(sLine, out number))
            {
                return false;
            }
            else
            {
                val = number;
                return true;
            }
        }
    }
}