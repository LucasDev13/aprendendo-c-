using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class VariaveisFlutuantes
    {
        public void run(){
            Console.WriteLine("Variáveis ponto flutuante...");
            
            double salario;
            salario = 5000.00;
            Console.WriteLine("Meu salario: "+salario);

            double idade;
            idade = 15/2;
            Console.WriteLine("15/2 = "+idade);

            idade = 5 / 2;
            Console.WriteLine("5/2 = "+ idade);
            
            idade = 5.0 / 3;
            Console.WriteLine("5.0/3 = " + idade);


            Console.WriteLine("Fim-Variáveis ponto flutuante...");
        }
    }
}