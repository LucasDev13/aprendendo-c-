using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class GuardandoValoresEmVariaveis
    {
        public void run(){
            Console.WriteLine("Guardando valores em variáveis...");

            int idade = 32;
            int idadeSugerida = idade;

            idade = 20;

            Console.WriteLine("idade: "+idade);
            Console.WriteLine("idade sugerida: "+idadeSugerida);

            Console.WriteLine("Fim-Guardando valores em variáveis...");
        }
    }
}