using lista;
using System;
using System.Collections.Generic;

namespace fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Essa é a Fila!");
            Queue<Palavra> pessoas = new Queue<Palavra>();
            pessoas.Enqueue(new Palavra("Jean"));
            pessoas.Enqueue(new Palavra("Isabela"));
            pessoas.Enqueue(new Palavra("Bruna"));
            pessoas.Enqueue(new Palavra("Pedro"));
            pessoas.Enqueue(new Palavra("Vitor"));

            Console.WriteLine($"O Primeiro da Fila é: { pessoas.Dequeue()}");
            pessoas.Peek();
            Console.WriteLine($"O número de pessoas na fila é: {pessoas.Count}");

            foreach (Palavra pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
