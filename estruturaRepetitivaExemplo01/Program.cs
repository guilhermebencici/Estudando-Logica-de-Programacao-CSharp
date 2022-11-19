using System;

namespace Estudando
{
    class program
    {
        static void Main(string[] args)
        {
            int x, soma;

            x = int.Parse(Console.ReadLine());
            soma = 0;
            while(x != 0)
            {
                soma += x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O valor digitado foi " + x + ". Programa encerrado!" + " A soma é: " + soma);
            Console.ReadLine();
        }
    }
}