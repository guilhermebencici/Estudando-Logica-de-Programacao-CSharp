using System;


namespace Estudando
{
    class program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];// instanciando o vetor

            string[] s = Console.ReadLine().Split(' '); //Split mantem na mesma linha
            for ( int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }

        }
    }
}