using lista;
using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta é a Pilhaaa de livros!");

            Stack<Palavra> livros = new Stack<Palavra>();
            livros.Push(new Palavra("Limite Zero"));
            livros.Push(new Palavra("Destrua este diário"));
            livros.Push(new Palavra("tres porquinhos"));

            livros.Peek();
            livros.Pop();
            Console.WriteLine($"O número de livros na Pilha é: {livros.Count}");

            foreach (Palavra livro in livros) 
            {
                Console.WriteLine($"Título na nossa pilha: {livro}");
            }

        }
    }
}
