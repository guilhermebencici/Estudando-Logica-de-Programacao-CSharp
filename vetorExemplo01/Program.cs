using System;
using System.Globalization;

namespace Estudando
{
    class program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N]; // instanciando o vetor
            

            for (int i = 0; i < N; i++) // i=0, porque o vetor incia com 0
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //for utilizado para percorrer o vetor preenchido e imprimir na tela seus elementos
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}