using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_dotnet
{
    public class ConversoesEOutrosTiposNumericos
    {
        public void run(){
            Console.WriteLine("Conversões e outros tipos numéricos...");

            double salario;
            salario = 1200.50;

            Console.WriteLine("Salario em double: "+salario);

            //int = 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine("Salario em inteiro: "+salarioEmInteiro);

            //long = 64 bits
            long idade;
            idade = 1300000000000000000;

            Console.WriteLine("Idade da terra: "+idade);

            //short = 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;

            Console.WriteLine("Quantidade de produtos: "+quantidadeProdutos);

            //float = precisao apos a virgula menor que o float.
            float altura = 1.80f;

            Console.WriteLine("Altura: "+altura);

            Console.WriteLine("Fim-Conversões e outros tipos numéricos...");
        }
    }
}/*  */