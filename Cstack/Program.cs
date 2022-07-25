using System;
using System.Collections.Generic;

namespace Cstack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Pilha!");

            Stack<Pessoa> stack = new Stack<Pessoa>();

            stack.Push(new Pessoa("André", "Boston", 36));
            stack.Push(new Pessoa("Silvio", "Oklahoma", 36));
            stack.Push(new Pessoa("Gu", "Massashussets", 36));
            stack.Push(new Pessoa("Paulinho", "Cancún", 36));

            Console.WriteLine($"Quantidade de pessoas: { stack.Count}");

            Console.WriteLine($"Primeira pessoa do topo: {stack.Peek()}");

            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }
}
