using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class ForEncadeado
    {
        public void run(){
            Console.WriteLine("Calcula poupança...");

                //Escrevendo * com o break.
                for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++){
                    for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++){
                        Console.Write("*");
                        if(contadorColuna >= contadorLinha)
                            break;
                    }
                    Console.WriteLine();
                }

                //Uma forma diferente de fazer o dezenho de *
                for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++){
                    for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++){
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            Console.WriteLine("Fim-Calcula poupança...");
        }
    }
}