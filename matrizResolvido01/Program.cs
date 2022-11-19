using System;
using System.Globalization;

namespace Estudando
{
    class program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A; // a virgula dentro dos [] representa MATRIZ

            N = int.Parse(Console.ReadLine());
            A = new int[N, N]; //instanciando matriz quadrada [N,N]

            // criamos um for para a linha "i" e outro para a coluna "j"
            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i, i] + " ");
            }

            int quantidade = 0;
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(A[i, j] < 0)
                    {
                        quantidade++;
                    }
                }
            }
            Console.WriteLine("A QUANTIDADE DE NEGATIVOS É: " + quantidade);
        }

    }
}