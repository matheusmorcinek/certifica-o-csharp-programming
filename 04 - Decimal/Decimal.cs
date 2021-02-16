class Decimal
{

    public void Executar()
    {

        double valorProduto = 10;
        double valorProduto2 = 20;
        double subtotal = 30;

        System.Console.WriteLine($"Descobrindo se 10 + 20 == 30");
        System.Console.WriteLine((valorProduto + valorProduto2) == subtotal);

        valorProduto = 10.10;
        valorProduto2 = 20.10;
        subtotal = 30.30;

        System.Console.WriteLine($"\nDescobrindo se 10 + 20 == 30");
        System.Console.WriteLine((valorProduto + valorProduto2) == subtotal); // o resultado é falso, pq internamente double e float armazena o numero de forma binaria, e arrendonda o numero

        //internamente é representado como um numero decimal e nao binario, evitando o problem anterior quando utilizamos double ou float

        decimal materiaPrima = 10.1M; // ou sufixo 10.1m
        decimal maoDeObra = 20.2M;
        decimal custo = 30.3M;

        System.Console.WriteLine($"Descobrindo se 10.1 + 20.2 == 30.3");
        System.Console.WriteLine((materiaPrima + maoDeObra) == custo);

        //valor monetarios sempre utilizar decimal!! 

    }
}