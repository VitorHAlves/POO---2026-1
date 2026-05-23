using ITributavel;
internal class Program
{
    private static void Main(string[] args)
    {
        Itributavel it;
        ContaCorrente c = new ContaCorrente();
        c.Depositar(1000);
        it = c;
        it.CalculaTributos();
        TotalizadorTributos totalizador = new TotalizadorTributos();
        totalizador.Adiciona(it);

        SeguroDeVida sv = new SeguroDeVida();
        it = sv;
        it.CalculaTributos();
        totalizador.Adiciona(it);

        Console.WriteLine($"Total de tributos acumluados: {totalizador.Total}");
    }
}