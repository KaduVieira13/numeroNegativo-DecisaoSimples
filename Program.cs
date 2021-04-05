using System;

namespace numeroNegativo_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("--- Numero negativo ---\n");
            
            Console.Write("Digite um numero: ");

            int numeroDigitado = Convert.ToInt32(Console.ReadLine());
            
            if (numeroDigitado <= 0)
            {
                Console.WriteLine($"{numeroDigitado} está no formato negativo. ");
            }
            else
            {
                Console.WriteLine($"O numero {numeroDigitado} está correto.");
            }
        }
    }
}
