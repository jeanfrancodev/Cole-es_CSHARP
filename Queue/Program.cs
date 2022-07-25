using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World fila!");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();
            pessoas.Enqueue(new Pessoa("João", "Los Santos", 12));
            pessoas.Enqueue(new Pessoa("Maria", "São Paulo", 12));
            pessoas.Enqueue(new Pessoa("Steve", "Ohio", 12));

            Console.WriteLine($"Object primeiro da fila é: {pessoas.Count}");

            pessoas.Peek();

            Console.WriteLine($"O numero de pessoas na fila é: {pessoas.Count}");   

            foreach(Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }
        }


        public class Pessoa
{
            public string Nome { get; set; }
            public string Cidade { get; set; }
            public int Idade { get; set; }

            public Pessoa(String nome, string cidade, int idade)
            {
                Nome = nome;
                Cidade = cidade;
                Idade = idade;
            }
            public override string ToString()
            {
                return $"Nome: {Nome} | Cidade: {Cidade} | Idade: {Idade}";
            }
        }
    }
}

