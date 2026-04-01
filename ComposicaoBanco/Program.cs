using ComposicaoBanco;
internal class Program
{
    private static void Main(string[] args)
    {
        Poupanca c1 = new Poupanca();
        c1.Depositar(500);
        c1.Sacar(50);
        c1.GerarRendimento();
    }
}