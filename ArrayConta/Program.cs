using ArrayConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //declaração de vetor - fora do laço
        Conta[] vetConta = new Conta[3];
        double total = 0;
        for (int i = 0; i < vetConta.Length; i++)
        {
            //instanciação de cada índice
            vetConta[i] = new Conta();
            Console.Write("Digite o numero da conta: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            vetConta[i].titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
            total += vetConta[i].saldo;

        }
        Console.WriteLine($"O saldo total é R${total}");
    }
}