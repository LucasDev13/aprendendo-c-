using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class Condicionais2
    {
        public void run(){
            Console.WriteLine("Condicionais2 com IF...");

            int idade = 15;
            //int quantidadePessoas = 2;

            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if(idade >= 18 && acompanhado == true){
                Console.WriteLine("Idade: " + idade + " Pode entrar.");
            }else{
                Console.WriteLine("Idade: " + idade + " Não pode entrar.");
            }

            Console.WriteLine("Fim-Condicionais2 com IF...");
        }
    }
}