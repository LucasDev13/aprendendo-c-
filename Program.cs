using System;

namespace primeiro_projeto_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Teste();
            Console.WriteLine("Hello World!");
            teste.primeiroTeste();

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = idade + 5;
            Console.WriteLine("Sua idade é: " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("Sua idade é " + idade + " ?");

            idade =  (10 + 5) * 2;
            Console.WriteLine(idade);

            Console.WriteLine("Execução finalizada. Tecle enter para sair!!");
            Console.ReadLine();
        }
    }
}
