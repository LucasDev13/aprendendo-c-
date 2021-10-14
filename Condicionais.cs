using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class Condicionais
    {
        public void run(){
            Console.WriteLine("Condicionais com IF...");

            int idade = 15;
            int quantidadePessoas = 2;
            if(idade >= 18){
                Console.WriteLine("Idade: " + idade);
            }else{
                if(quantidadePessoas >= 2){
                    Console.WriteLine("Não é maior que 18 mas está acompanhado.");
                }else{
                Console.WriteLine("idade menor que  18 e não está acompanhado." );
                }
            }

            Console.WriteLine("Fim-Condicionais com IF...");
        }
    }
}