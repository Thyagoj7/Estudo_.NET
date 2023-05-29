using Contrutores;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

       Jogador j1 = new Jogador(a);
       Jogador j2 = new Jogador(b);

        Jogador bol = new Jogador();

        bol.saldoGol(a);

       

        var ax=j1.energia;
        var ay=j2.energia;

      Console.WriteLine(ax + " e " + ay);


    }
}