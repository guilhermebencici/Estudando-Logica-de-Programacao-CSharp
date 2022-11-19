using System;
using System.Diagnostics.Tracing;

namespace Estudando
{
    class Program
    {
        /* static void Main(string[] args)
		{

			int x = int.Parse(Console.ReadLine());
			string dia;

			if ( x == 1)
			{
				dia = "domingo";
			}
			else if(x == 2)
			{
				dia = "segunda";
			}
            else if (x == 3)
            {
                dia = "trça";
            }
            else if (x == 4)
            {
                dia = "quarta";
            }
            else if (x == 5)
            {
                dia = "quinta";
            }
            else if (x == 6)
            {
                dia = "sexta";
            }
            else if (x == 7)
            {
                dia = "sábado";
            }
            else
            {
                dia = "Valor inválido";
            }

            Console.WriteLine("Dia da semana: " + dia);

            Console.ReadLine();
        } */


        // utilizando a ideia do código acima, mas em Switch-case

        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;

                case 7:
                    dia = "Sábado";
                    break;
                default:
                    dia = "Valor inválido";
                    break;                    
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();

        }
    }
}