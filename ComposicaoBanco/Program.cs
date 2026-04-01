using ComposicaoBanco;
internal class Program
{
    private static void Main(string[] args)
    {
        ContaCorrente c1 = new ContaCorrente(2000);
        c1.Depositar(500);
        c1.Sacar(2501);
        c1.GerarExtrato();
    }
}