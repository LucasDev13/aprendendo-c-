using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class CalculaInvestimentoLongoPrazo
    {
        public void run(){
            Console.WriteLine("Calcula poupança...");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            //contagem do ano a ano
            for (int i = 1; i <= 5 ; i++)
            {
                //contagem mês a mês
                //0.36% == 0.0036
                //valorInvestido += valorInvestido * 0.0036;        
                for(int contador = 1; contador <= 12; contador++){    
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Após " + contador + " mês, você terá R$ - " + valorInvestido);
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento, você terá R$ - " + valorInvestido);
            

            Console.WriteLine("Fim-Calcula poupança...");
    }
    }
}