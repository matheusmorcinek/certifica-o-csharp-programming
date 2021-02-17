class Interfaces
{

    public void Executar()
    {

        Televisao televisao = new Televisao();
        televisao.Ligar();

        Abajur abajur = new Abajur();
        abajur.Ligar();
    }

}

interface IEletrodomestico
{

    void Ligar();
    void Desligar();
}

interface IIluminacao {
    double potenciaLampada { get; set; }
}

class Televisao : IEletrodomestico
{
    public void Desligar()
    {
        throw new System.NotImplementedException();
    }

    public void Ligar()
    {
        throw new System.NotImplementedException();
    }
}

class Abajur : IEletrodomestico, IIluminacao
{
   public double potenciaLampada { get; set; }

    public void Desligar()
    {
        throw new System.NotImplementedException();
    }

    public void Ligar()
    {
        throw new System.NotImplementedException();
    }
}

class Lanterna : IEletrodomestico, IIluminacao
{

    public double potenciaLampada { get; set; }
    
    public void Desligar()
    {
        throw new System.NotImplementedException();
    }

    public void Ligar()
    {
        throw new System.NotImplementedException();
    }
}