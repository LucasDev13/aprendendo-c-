using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class CaracteresETextos
    {
        public void run(){
            Console.WriteLine("Caracteres e textos...");

            //character
            char primeiraLetra = 'a'; //pode ser atribuido para o char o espaço ' ';
            Console.WriteLine(primeiraLetra);
            
            //o char segue o asc table para os numeros.
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            String titulo = "Alura cursos de tecnologia! " + 2020;
            Console.WriteLine("String do titulo: "+titulo);

            Console.WriteLine("Fim-Caracteres e textos...");
        }
    }
}