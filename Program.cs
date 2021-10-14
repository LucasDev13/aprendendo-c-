using System;

namespace primeiro_projeto_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Teste();
            Console.WriteLine("Hello World!");
            //teste.primeiroTeste();

            //var variaveisInteiras = new VariaveisInteiras();
            //variaveisInteiras.run();

            var variaveisFlutuantes = new VariaveisFlutuantes();
            variaveisFlutuantes.run();



            Console.WriteLine("Execução finalizada. Tecle enter para sair!!");
        }
    }
}
