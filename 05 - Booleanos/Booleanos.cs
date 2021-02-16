using System;
class Booleanos
{

    public void Executar()
    {

        bool possuiSaldo = true;

        System.Console.WriteLine($"Possui saldo: {possuiSaldo}");

        int dias = DateTime.Now.Day;
        System.Console.WriteLine($"Dias: {dias}");

        bool diasPar = (dias % 2 == 0);

        if (diasPar)
        {
            System.Console.WriteLine("Dias é par");
        }
        else
        {
            System.Console.WriteLine("Dias é impar");
        }

    }
}