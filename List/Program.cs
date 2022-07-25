using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Animais!");
            List<Palavra> Animais = new List<Palavra>();

            Animais.Add(new Palavra("Cavalo"));
            Animais.Add(new Palavra("Javali"));
            Animais.Add(new Palavra("Ornitorrinco"));
            Animais.Add(new Palavra("Galinha"));

            Animais.Insert(2, new Palavra("Gato"));
            Animais.Remove(new Palavra("Galinha"));
            Animais.RemoveAt(1);

            foreach (Palavra animal in Animais)
            {
                Console.WriteLine(animal);
            }
        }
    }

    public class Palavra
    {
        public string Nome { get; set; }

        public Palavra(string nome)
        {
            Nome = nome;
        }
        public override string ToString()
        {
            return Nome;
        }

    }

}


