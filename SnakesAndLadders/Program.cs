using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    class Program
    {
        private static Dictionary<int, int> snakeAndLadderLinks = new Dictionary<int, int>() {
            {4, 14},
            {9, 31},
            {17, 7},
            {20, 38},
            {28, 84},
            {40, 59},
            {51, 67},
            {54, 34},
            {62, 19},
            {63, 81},
            {64, 60},
            {71, 91},
            {87, 24},
            {93, 73},
            {95, 75},
            {99, 78},
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
