using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class Escopos
    {
        public void run(){
            Console.WriteLine("Condicionais2 com IF...");

            int idade = 15;
            bool acompanhado = false;
            //está sendo declarada na raiz do escopo do método.
            String mensagemAdicional;//variável está fora do contesto dos if

            if (acompanhado == true)
            {
                mensagemAdicional = "Está acompanhado";
            }else{
                mensagemAdicional = "Não está acompanhado";
            }

            if(idade >= 18 || acompanhado == true){
                Console.WriteLine("Idade: " + idade + " Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }else{
                Console.WriteLine("Idade: " + idade + " Não pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("Fim-Condicionais2 com IF...");
        }
    }
}