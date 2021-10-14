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

            //var variaveisFlutuantes = new VariaveisFlutuantes();
            //variaveisFlutuantes.run();

            //var conversoesEOutrosTiposNumericos =  new ConversoesEOutrosTiposNumericos();
            //conversoesEOutrosTiposNumericos.run();

            //var caracteresETextos = new CaracteresETextos();
            //caracteresETextos.run();

            //var guardandoValoresEmVariaveis = new GuardandoValoresEmVariaveis();
            //guardandoValoresEmVariaveis.run();

            var condicionais = new Condicionais();
            condicionais.run();

            Console.WriteLine("Execução finalizada. Tecle enter para sair!!");
        }
    }
}
