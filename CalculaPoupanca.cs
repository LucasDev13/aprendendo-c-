using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class CalculaPoupanca
    {
        public void run(){
            Console.WriteLine("Calcula poupança...");

            double valorInvestido = 1000;

            //0.36% == 0.0036
            //valorInvestido += valorInvestido * 0.0036;            
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 1 mês, você terá R$ - " + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 2 mês, você terá R$ - " + valorInvestido);

            int contadorMes = 1;
            while(contadorMes <= 12){
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+ contadorMes +" mês, você terá R$ - " + valorInvestido);
                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                // o ++ serve para um unidade (1);
                contadorMes++;
            }

            Console.WriteLine("Fim-Calcula poupança...");
    }
}
}