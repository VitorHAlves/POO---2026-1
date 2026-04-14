using ClasseConta;// sem isso a main n usa a classe conta, e no arquivo conta ela deve estar public.
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();//Instância de objeto
        c1.numero = 1;
        c1.titular = "Fatec";
        c1.saldo = 100;
        c1.MostrarAtributos();
        c1.Sacar(50);   
        c1.MostrarAtributos();
        Conta c2 = new Conta();
        c2.MostrarAtributos();
        c2.Depositar(500);
        c2.MostrarAtributos();
        Console.Write("Digite o numero da conta: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite titular da conta: ");
        c2.titular = Console.ReadLine();
        c2.MostrarAtributos();
    }
}