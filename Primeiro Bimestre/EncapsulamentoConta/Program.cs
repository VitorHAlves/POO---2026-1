using EncapsulamentoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c = new Conta();
        c.Numero = 1; //acionando a setNumero(1);
        Console.WriteLine($"Número: {c.Numero}");// n ta atribuindo nd ent é o metodo get.
        c.Titular = "Rodrigo";
        Console.WriteLine($"Titular: {c.Titular:c}");
        c.Saldo = -13560;
        Console.WriteLine($"Saldo: {c.Saldo:c}");
    }
}