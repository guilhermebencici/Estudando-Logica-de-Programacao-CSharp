using System;
using System.Globalization;

namespace Estudando
{
    class program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("Nota Final: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if (soma < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();

        }
    }
}