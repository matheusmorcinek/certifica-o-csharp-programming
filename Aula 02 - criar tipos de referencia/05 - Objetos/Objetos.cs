class Objetos
{

    public void Executar()
    {

        int pontuacao = 10;
        System.Console.WriteLine($"pontuacao: {pontuacao}\n");

        System.Console.WriteLine("Object com valor primitivo");
        object meuObjeto;
        meuObjeto = pontuacao;
        System.Console.WriteLine(meuObjeto.GetType());
        System.Console.WriteLine($"meuObjeto: {meuObjeto}\n");

        System.Console.WriteLine("Object com referência de objeto");

        meuObjeto = new Jogador();
        Jogador classRef;
        classRef = (Jogador)meuObjeto; //conversao explicita ou cast

        System.Console.WriteLine($"classRef.pontuacao: {classRef.pontuacao}");
    }

}

class Jogador
{
    public int pontuacao { get; set; } = 10;
}