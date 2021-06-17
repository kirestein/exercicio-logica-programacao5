using System;

namespace somaAlgarismo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, soma = 0, resto = 0;

            Console.WriteLine("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                

                resto = n % 10;
                soma = soma + resto;
                n = n / 10;
            }

            Console.WriteLine(soma);
            

        }
    }
}
