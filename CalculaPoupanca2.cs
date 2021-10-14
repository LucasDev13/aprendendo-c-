using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class CalculaPoupanca2
    {
        public void run(){
            Console.WriteLine("Calcula poupança...");

            double valorInvestido = 1000;

            //0.36% == 0.0036
            //valorInvestido += valorInvestido * 0.0036;        
            for(int contador = 1; contador <= 12; contador++){    
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contador + " mês, você terá R$ - " + valorInvestido);
            }
            

            Console.WriteLine("Fim-Calcula poupança...");
    }
}
}