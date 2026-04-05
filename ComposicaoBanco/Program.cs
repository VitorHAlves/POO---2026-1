using ComposicaoBanco;
internal class Program
{
    private static void Main(string[] args)
    {
        Banco banco = new Banco();
        banco.IniciarBanco();

        banco.AbrirConta(500);
        banco.AbrirConta(300);

        banco.AbrirPoupanca();
        banco.AbrirPoupanca();

        banco.Contas[0].Depositar(1000);
        banco.Contas[0].Sacar(200);
        banco.Contas[0].GerarExtrato();

        banco.Poups[0].Depositar(500);
        banco.Poups[0].GerarRendimento();

        
        banco.Contas[1].Depositar(200);
        banco.Contas[1].Sacar(600); 
        banco.Contas[1].GerarExtrato();


        banco.Poups[1].Depositar(1000);
        banco.Poups[1].GerarRendimento();
        banco = null;
        GC.Collect();

    }
}