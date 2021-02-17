class Strings
{

    public void Executar() {

        string a = "bom dia";
        string b = "b";

        b += "om dia";
        System.Console.WriteLine(a == b);

        //tem o mesmo valor mas apontam para areas diferentes da memoria
        System.Console.WriteLine($"(object)a == (object)b: {(object)a == (object)b}");

        //uma string pode ser entendida como uma array de char
        string bomDia = "bom dia";
        System.Console.WriteLine(bomDia[4]);

        var caractere = bomDia[4];
        System.Console.WriteLine(caractere.GetType());

    }

}