using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Por favor, insira seu nome.");
            string nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Olá, " + nome + ".");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
