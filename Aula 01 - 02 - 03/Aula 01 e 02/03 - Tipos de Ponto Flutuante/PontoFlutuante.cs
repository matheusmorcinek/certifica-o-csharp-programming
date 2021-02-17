class PontoFlutuante
{

    public void Executar()
    {

        float idade = 29;
        idade = 29.5f;

        // int massaDaTerra = 6_000000_000000_000000_000000; erro
        // long massaDaTerra = 6_000000_000000_000000_000000; erro
        // long massaDaTerra = 6_000000_000000_000000_000000; erro
        // long massaDaTerra = 6e24; erro

        float massaDaTerra = 5.9736e24f; // System.Single single pq é um tipo de simples precisão
        System.Console.WriteLine($"Massa da Terra: {massaDaTerra}");

        float numeroPi = 3.14159f;
        System.Console.WriteLine($"Numero PI: {numeroPi}");

        // float numerMuitoMaior = 6e100f;
        double numerMuitoMaior = 6e100; //variavel de dupla precisao, 

        int x = 3;
        short y = 5;

        var resultado = x * y;
        System.Console.WriteLine($"Resultado de x * y é: {resultado}");
        System.Console.WriteLine($"resultado é do tipo: {resultado.GetType()}");

        float z = 4.5f;
        var resultado2 = (x * y) / z;

        System.Console.WriteLine($"Resultado de (x * y) / z é: {resultado2}");
        System.Console.WriteLine($"resultado é do tipo: {resultado2.GetType()}");

        //============================================================
        //float System.Single, precisão de 7 digitos
        //double System.Double precisão de 15-16 digitos
    }
}