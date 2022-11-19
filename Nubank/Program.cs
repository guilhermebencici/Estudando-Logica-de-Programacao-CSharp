using System;

namespace Estudando
{
    class programan
    {
        static void Main(string[] args)
        {
            int x = 1;
            int resultado;
            //x = int.Parse(Console.ReadLine());
            resultado = 0;
            for (int i = 1; i <= 128; i =+ i)
            {
                
                x += x;
                
            }
            Console.WriteLine(resultado);


        }
    }
}