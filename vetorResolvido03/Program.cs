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

            // estanciando os 3 vetores
            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            //Leitura dos dados:
            for(int i = 0; i < N; i++)
            {
                // criamos um vetor auxiliar, para receber os dados digitados
                string[] s = Console.ReadLine().Split(' ');

                //dados referentes a variavel nome, serão inseridos no indice 0 do vetor auxiliar s
                nomes[i] = s[0];
                //dados referentes a variavel idade, serão inseridos no indice 1 do vetor auxiliar s
                idades[i] = int.Parse(s[1]);
                //dados referentes a variavel altura, serão inseridos no indice 2 do vetor auxiliar s
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            // Calculo da altura média das pessoas
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            // percentual das pessoas abaixo de 16 anos
            int contagem = 0;
            for(int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    contagem++;
                }
            }
            double percentual = (double) contagem / N * 100.0; // o double ao lado de contagem evita o truncamento
            Console.WriteLine("Pessoas com menos de 16 anos: " + percentual.ToString("F1",CultureInfo.InvariantCulture) + "%");




        }
    }
}