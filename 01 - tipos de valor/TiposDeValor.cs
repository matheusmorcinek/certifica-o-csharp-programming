using System.ComponentModel.DataAnnotations;
using System;

public class TiposDeValor
{

    public void Executar()
    {

        int idade = 29;
        System.Console.WriteLine($"Idade: {idade}");

        int? novaIdade = null;
        // System.Nullable<int> novaIdade = null;
        System.Console.WriteLine($"Variavel to tipo Int32 que pode receber valor nulo: {novaIdade}");
    }
}