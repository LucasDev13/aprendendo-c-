using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class VariaveisInteiras
    {
        public void run(){
            Console.WriteLine("Variáveis inteiras...");
            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = idade + 5;
            Console.WriteLine("Sua idade é: " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("Sua idade é " + idade + " ?");

            idade =  (10 + 5) * 2;
            Console.WriteLine(idade);
            Console.WriteLine("Fim-Variáveis inteiras...");
        }
    }
}