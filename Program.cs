using System;

namespace certificacao_csharp_programming
{
    class Program
    {
        static void Main(string[] args)
        {

            TiposDeValor tipos = new TiposDeValor();
            // tipos.Executar();

            Inteiros inteiros = new Inteiros();
            // inteiros.Executar();

            PontoFlutuante pontoFlutuante = new PontoFlutuante();
            // pontoFlutuante.Executar();

            Decimal dec = new Decimal();
            // dec.Executar();

            Booleanos booleanos = new Booleanos();
            // booleanos.Executar();

            Estruturas estruturas = new Estruturas();
            // estruturas.Executar();

            Enumeracoes enumeracoes = new Enumeracoes();
            enumeracoes.Executar();
        }
    }
}
