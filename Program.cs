using System;

namespace Exercício_da_padaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            String name = Console.ReadLine();
            Console.WriteLine($"Olá {name}!");
            
            Console.Write("Digite o produto que gostaria de comprar: ");
            String product = Console.ReadLine();
            Console.WriteLine($"Voce quer comprar {product}!");
            
            Console.Write($"Digite a quantidade de {product} que gostaria de comprar: ");
            float quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"Voce gostaria de comprar {quantity} unidades de {product}!");

            Console.Write($"Digite o valor do {product} que gostaria de comprar: ");
            float value = int.Parse(Console.ReadLine());
            float some1 = (quantity * value);

            string value1 = $"Voce vai pagar o valor de ${some1} por {quantity} unidades de {product}!";
            Console.WriteLine(value1);

        }
    }
}
