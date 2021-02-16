class Estruturas
{

    public void Executar()
    {

        double Latitude1 = 13.78;
        double Longitude1 = 29.51;
        double Latitude2 = 40.23;
        double Longitude2 = 17.4;
        System.Console.WriteLine($"Latitude1 {Latitude1}");
        System.Console.WriteLine($"Longitude1 {Longitude1}");
        System.Console.WriteLine($"Latitude2 {Latitude2}");
        System.Console.WriteLine($"Longitude2 {Longitude2}");

        PosicaoGPS posicao1;
        posicao1.Latitude = 13.78;
        posicao1.Longitude = 29.51;

        var posicao2 = new PosicaoGPS()
        {
            Latitude = 40.23,
            Longitude = 17.4
        };

        PosicaoGPS posicao3 = new PosicaoGPS(30.1, 57.10);

        // posicao3 = posicao2;
        // posicao3.Longitude = 0;

        System.Console.WriteLine(posicao1);
        System.Console.WriteLine(posicao2);
        System.Console.WriteLine(posicao3);

    }

    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGPS(double latitude, double longitude)
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
}