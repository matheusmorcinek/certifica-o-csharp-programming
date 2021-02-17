class Delegates
{

    public void Executar()
    {

        Calculadora.Executar();
    }

}

delegate double MetodoMultiplicacao(double input);

class Calculadora
{

    static public double Duplicar(double input)
    {

        return input * 2;
    }

    static public double Triplicar(double input)
    {

        return input * 3;
    }

    public static void Executar()
    {


        System.Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");
        System.Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}\n");

        MetodoMultiplicacao metodoMultiplicacao = Duplicar;
        System.Console.WriteLine("usando delegate com duplicar");
        System.Console.WriteLine($"Duplicar(7.5): {metodoMultiplicacao(7.5)}");

        metodoMultiplicacao = Triplicar;

        System.Console.WriteLine("usando delegate com triplicar");
        System.Console.WriteLine($"Triplicar(7.5): {metodoMultiplicacao(7.5)}");

        //instancia um delegate com um metodo anonimo
        MetodoMultiplicacao metodoQuadrado = delegate (double input)
        {
            return input * input;
        };

        double quadradoResultado = metodoQuadrado(5);
        System.Console.WriteLine($"Quadrado: {quadradoResultado}\n");

        //instancia um delegate com um expressao lambda
        MetodoMultiplicacao metodoCubo = input => input * input * input;

        System.Console.WriteLine($"Cubo de 5: {metodoCubo(5)}");
    }
}