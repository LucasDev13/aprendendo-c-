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

            //var condicionais = new Condicionais();
            //condicionais.run();

            //var condicionais2 = new Condicionais2();
            //condicionais2.run();

            //var escopos = new Escopos();
            //escopos.run();

            //var calculaPoupanca = new CalculaPoupanca();
            //calculaPoupanca.run();

            //var calculaPoupanca2 = new CalculaPoupanca2();
            //calculaPoupanca2.run();

            var calculaInvestimentoLongoPrazo = new CalculaInvestimentoLongoPrazo();
            calculaInvestimentoLongoPrazo.run();

            Console.WriteLine("Execução finalizada. Tecle enter para sair!!");
        }
    }
}
