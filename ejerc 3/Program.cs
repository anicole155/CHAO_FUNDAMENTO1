﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese # filas:");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese # columnas:");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];
            int[] suma = new int[c];
            Random rnd = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(30, 51);
                    suma[j] += matriz[i, j];
                    Console.WriteLine(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < c; i++)
            {
                Console.Write(suma[i] + "\t");
            }
            Console.ReadKey(); 
          
        }
    


    }
}
