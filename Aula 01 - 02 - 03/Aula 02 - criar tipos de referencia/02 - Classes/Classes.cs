using System;

public class Classes
{

    public void Executar()
    {


        ClassePosicaoGPS posicao1 = new ClassePosicaoGPS();
        posicao1.Latitude = 13.78;
        posicao1.Longitude = 29.51;

        var posicao2 = new ClassePosicaoGPS()
        {
            Latitude = 40.23,
            Longitude = 17.4
        };

        ClassePosicaoGPS posicao3 = new ClassePosicaoGPS(30.1, 57.10);

        // posicao3 = posicao2;
        // posicao3.Longitude = 0;

        System.Console.WriteLine(posicao1);
        System.Console.WriteLine(posicao2);
        System.Console.WriteLine(posicao3);

        var posicao5 = new PosicaoGPSComLeitura(40.2, 12.1, DateTime.Now);

        System.Console.WriteLine($"\n{posicao5}");
    }
}

public class ClassePosicaoGPS
{
    public double Latitude;
    public double Longitude;

    public ClassePosicaoGPS()
    {
    }

    public ClassePosicaoGPS(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public bool EstaNoHemisferioNorte()
    {
        return Latitude > 0;
    }

    public override string ToString()
    {
        return $"Latitude {Latitude}, Longitude {Longitude}";
    }
}


class PosicaoGPSComLeitura : ClassePosicaoGPS
{
    private readonly DateTime dataLeitura;

    public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
    {
        this.dataLeitura = dataLeitura;
    }

    public override string ToString()
    {
        return $"Latitude {Latitude}, Longitude {Longitude}, Data da Leitura {dataLeitura}";
    }
}

