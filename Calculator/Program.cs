using System;

namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // limpar a tela
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(v1);
        }
    }
}