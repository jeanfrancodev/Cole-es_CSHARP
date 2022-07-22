using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine(" Dicionário Gen! ");
            Console.WriteLine("-----------------");
            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict.Add(("Persistência\n"), (" Ato de se manter no mesmo caminho, mesmo diante das dificuldades.\n"));
            dict.Add(("Mentalidade de Crescimento\n"), ("Acreditar que suas competências mais básicas podem ser desenvolvidas através de dedicação e trabalho árduo.\n"));
            dict.Add(("Responsabilidade Pessoal\n"), ("Assumir as responsabilidades por suas próprias ações, mantendo o compromisso.\n"));
            dict.Add(("Orientação ao Futuro\n"), ("Estabelecer metas pro futuro, compreender como as ações de hoje impactam nessas metas.\n"));
            dict.Add(("Comunicação"), ("Intrumento verba"));

            foreach (KeyValuePair<string, object> kvp in dict)
            {
                Console.WriteLine($"|Palavra: {kvp.Key}|significado = {kvp.Value}");
            }
        }
    }
}
