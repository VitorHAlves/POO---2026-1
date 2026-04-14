using EncapsulamentoArrayConta;

Conta[] vetConta = new Conta[2];
for(int i = 0; i < vetConta.Length;i++)
{
    vetConta[i] = new Conta();
    Console.Write("Digite o número: ");
    vetConta[i].Numero = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o titular: ");
    vetConta[i].Titular = Console.ReadLine();
    Console.Write("Digite o saldo: ");
    vetConta[i].Saldo = Convert.ToDouble(Console.ReadLine());
}