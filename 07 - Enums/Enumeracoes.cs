using System;

public class Enumeracoes
{

    public void Executar()
    {
        const int Seg = 0;
        const int Ter = 1;
        const int Qua = 2;
        //...

        DiasDaSemana primeiroDia = DiasDaSemana.Segunda;
        System.Console.WriteLine($"Dia da semana: {primeiroDia}");

        DiasDeTrabalho diasDeTrabalho = DiasDeTrabalho.Seg | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex;
        System.Console.WriteLine(diasDeTrabalho);
    }

    //para definir um tipo
    //  enum DiasDaSemana : long
    //     {
    //         Segunda = 0,
    //         Terça,
    //         Quarta,
    //         Quinta,
    //         Sexta,
    //         Sabado,
    //         Domingo
    //     }
    enum DiasDaSemana
    {
        Segunda = 0,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sabado,
        Domingo
    }

    // [Flags]
    [Flags]
    enum DiasDeTrabalho {
        Seg = 0,
        Ter = 1,
        Qua = 2,
        Qui = 4,
        Sex = 8,
        Sab = 16,
        Dom = 32
    }
}