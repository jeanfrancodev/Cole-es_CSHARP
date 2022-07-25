using System;
using System.Collections.Generic;


namespace Clist
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World Lista!");
            
            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(new Pessoa"Jean");
            lista.Add("Isa");
            lista.Add("Bruna");
            lista.Add("Vitor");

            lista.Insert(1, Pedro);

            lista.Remove("Bruna");
            lista.RemoveAt(2);

            foreach (string nome in lista) 
            {
                Console.WriteLine($"Aqui esta a Pessoa:{nome}");
            }




        }
    }
}
