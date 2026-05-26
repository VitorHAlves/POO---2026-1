using ExercicioSRP;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c = new Conta("Vitor");
        c.Deposito(1000);
        c.Sacar(55);

        ValidadadorUsuarios validador = new ValidadadorUsuarios();
        bool valido = validador.ValidarUsuario(c,"Vitor");

        if (valido){
            Console.WriteLine("Usuário validado!");
            GeradorRelatorios gerador = new GeradorRelatorios();
            string? relatorio = gerador.GerarRelatorio(c);
            Console.WriteLine($"Relatório: {relatorio}");
        }
        else{
            Console.WriteLine("Usuário inválido");
        }

    }
}