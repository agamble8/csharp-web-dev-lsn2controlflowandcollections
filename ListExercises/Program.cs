using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> practiceNumbers = new List<float> {1, 2, 8, 8, 8, 3, 20, 87, 9, 1, 0};

            Console.WriteLine(Sum.AddList(practiceNumbers));

        }
    }

 }
