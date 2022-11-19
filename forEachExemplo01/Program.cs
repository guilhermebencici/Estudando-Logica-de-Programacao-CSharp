using System;
using System.Globalization;

namespace Estudando
{
    class program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes Lidos: ");
            // utilizamos o foreach quando queremos percorrer todos os valores de uma coleção
            foreach (string elementos in vet)
            {
                Console.WriteLine(elementos);
            }

            
        }

    }
}