﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MatrizesParte1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length);
            Console.WriteLine(matriz.Rank);
            Console.WriteLine(matriz.GetLength(1));
            Console.WriteLine(matriz.GetLength(0));

            Console.ReadLine();
        }
    }
}
