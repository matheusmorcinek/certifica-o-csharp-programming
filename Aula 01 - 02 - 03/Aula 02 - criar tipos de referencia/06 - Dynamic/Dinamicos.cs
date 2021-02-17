class Dinamicos
{

    public void Executar()
    {

        object objeto = 1;
        //objeto = objeto + 1; erro

        dynamic dinamico = 1;
        dinamico = dinamico + 1;

        System.Console.WriteLine($"dinamico: {dinamico}\n"); 

        dynamic pessoa1 = new { nome = "Matheus", sobrenome = "Morcinek" };
        System.Console.WriteLine(pessoa1.sobrenome);

        dynamic pessoa2 = new Pessoa();
        pessoa2.Nome = "Bruna";

        System.Console.WriteLine(pessoa2.Nome);

    }

}

class Pessoa
{
    public string Nome { get; set; }
}