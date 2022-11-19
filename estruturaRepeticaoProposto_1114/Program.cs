using System;

namespace Estudando
{
    class program
    {
        static void Main(string[] args)
        {
            int senhaValida;

            while (true)
            {
                senhaValida = int.Parse(Console.ReadLine());

                if (senhaValida == 2002) break;
                Console.WriteLine("Senha Invalida");

            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}