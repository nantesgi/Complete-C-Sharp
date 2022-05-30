using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MatrizesParte3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine()); //quantidade de linhas
            int n = int.Parse(Console.ReadLine()); //quantidade de colunas

            int[,] matriz = new int[n, n];

            // leitura da matriz
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine()); // numero a ser buscado

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.Write("Position ");
                        Console.Write(i);
                        Console.WriteLine(", " + j + ": ");

                        if (j > 0)
                        {
                            Console.Write("Left: ");
                            Console.WriteLine(matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.Write("Up: ");
                            Console.WriteLine(matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.Write("Right: ");
                            Console.WriteLine(matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.Write("Down: ");
                            Console.WriteLine(matriz[i + 1, j]);
                        }
                    }
                }
            }

            //Console.WriteLine("Diagonal principal: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(matriz[i, i] + " ");
            //}

            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (matriz[i, j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine("Números negativos: " + count);

            Console.ReadLine();
        }
    }
}
