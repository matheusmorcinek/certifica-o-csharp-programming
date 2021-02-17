public class TiposDeReferencia
{

    public void Executar()
    {

        int idade = 29;
        int copiaIdade = idade;

        System.Console.WriteLine($"idade {idade}");
        System.Console.WriteLine($"copiaIdade {copiaIdade}");

        idade = 10;

        System.Console.WriteLine($"idade = 10;");
        System.Console.WriteLine($"idade {idade}");
        System.Console.WriteLine($"copiaIdade {copiaIdade}");

        System.Console.WriteLine("\nAgora usando um struct\n");

        var cliente1 = new Cliente("Matheus Morcinek", 29);
        var cliente2 = cliente1;

        System.Console.WriteLine(cliente1);
        System.Console.WriteLine(cliente2);   

        cliente1.Nome = "Bruna";

        System.Console.WriteLine("cliente1.nome = Bruna");
        System.Console.WriteLine(cliente1);
        System.Console.WriteLine(cliente2);   


        System.Console.WriteLine("\nTipo de valor é diferente de tipo de referência\n");
        System.Console.WriteLine("\nAgora usando uma class\n");

        var empregado1 = new Empregado("Matheus", 29);
        var empregado2 = empregado1;

        System.Console.WriteLine(empregado1);
        System.Console.WriteLine(empregado2);

        empregado1.Nome = "Bruna";

        System.Console.WriteLine("empregado1.Nome = Bruna");
        System.Console.WriteLine(empregado1);
        System.Console.WriteLine(empregado2);

    }

    class Cliente {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, int idade){

            Nome = nome;
            Idade = idade;    
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }

    class Empregado {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Empregado(string nome, int idade){

            Nome = nome;
            Idade = idade;    
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
}