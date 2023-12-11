﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_3er_semestre_Algoritmos_C__consola
{
    internal class Selectionsort
    {
        public Selectionsort() { }

        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                // Encontrar el índice del mínimo elemento en el subarreglo no ordenado
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Intercambiar el mínimo encontrado con el primer elemento del subarreglo no ordenado
                Swap(ref arr[i], ref arr[minIndex]);
            }

        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
