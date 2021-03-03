using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Pressione uma tecla para iniciar a contagem");
            Console.ResetColor();
            Console.ReadKey();
            Console.Beep();
            Console.WriteLine("Preparar...");
            Console.Beep();
            Console.ReadKey();
            Console.WriteLine("Apontar...");
            Console.Beep();
            Console.ReadKey();
            Console.WriteLine("Fogo!");
            Console.Beep();
        }
    }
}
