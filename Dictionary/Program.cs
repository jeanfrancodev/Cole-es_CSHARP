using System;
using System.Collections.Generic;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(" Dicionário Generation! ");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            Dictionary<string, string> dict2 = new Dictionary<string, string>();
            Console.WriteLine("Essas são as MENTALIDADES\n");
            dict1.Add(("Persistência"), ("Ato de se manter no mesmo caminho, mesmo diante das dificuldades.\n"));
            dict1.Add(("Mentalidade de Crescimento"), ("Acreditar que suas competências mais básicas podem ser desenvolvidas\n através de dedicação e trabalho árduo.\n"));
            dict1.Add(("Responsabilidade Pessoal"), ("Assumir as responsabilidades por suas próprias ações, mantendo o compromisso.\n"));
            dict1.Add(("Orientação ao Futuro"), ("Estabelecer metas pro futuro, compreender como as ações de hoje impactam nessas metas.\n"));
            foreach (KeyValuePair<string, string> kvp in dict1)
            {
                Console.WriteLine($"|Palavra: {kvp.Key}| \n significado: {kvp.Value}\n");
            }
            
            Console.WriteLine("Essas são as HABILIDADES \n");

            dict2.Add(("Comunicação"), ("Significa capacidade de expressar ideias de forma clara e concisa,\n com linguagem apropriada ao público, assim como ouvir com atenção"));
            dict2.Add(("Proatividade"), ("Significa assumir a liderança em seu emprego sem nenhum impulso de seu gerente,\n antecipando situações e tomando as ações preventivas que forem necessárias."));
            dict2.Add(("Orientação ao detalhe"), ("Consiste em estar constantemente atento aos detalhes ao executar tarefas,\n a fim de serem completadas com precisão e cuidado."));
            dict2.Add(("Trabalho em equipe"), ("Consiste em um grupo de pessoas, ou apenas duas pessoas,\n trabalhando em conjunto visando um objetivo em comum."));
            foreach (KeyValuePair<string, string> kvp in dict2)
            {
                Console.WriteLine($"|{kvp.Key}| \n Significado: {kvp.Value}\n");
            }
        }
    }
}
