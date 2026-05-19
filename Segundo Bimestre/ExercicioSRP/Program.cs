using ExercicioSRP;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c = new Conta("Vitor");
        c.Deposito(1000);
        c.Sacar(55);
    }
}