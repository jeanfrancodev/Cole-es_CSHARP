using System;
using System.Collections.Generic;


namespace CDictionary 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Dicionario!");

            Dictionary<string, Pessoa> dic = new Dictionary<string, Pessoa>();

            dic.Add("Jepan", new Pessoa("Jean", "Guarulhos", 29));
            dic.Add("Vó", new Pessoa("Avó", "Rio de Janeiro", 69));
            dic.Add("Mainha", new Pessoa("Mãe", "Guarujá", 50));

            foreach(KeyValuePair<string, Pessoa> keyValuePair in dic)
            {
                Console.WriteLine($"Chave = {keyValuePair.Key} | Valor =    {keyValuePai    r.Value}");      
            }

        }
    }
}
