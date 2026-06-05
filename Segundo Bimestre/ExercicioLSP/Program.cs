using System.ComponentModel;
using ExercicioLSP;

static void RealizarSaque(IConta conta, decimal valor)
{
    conta.Sacar(valor);
    Console.WriteLine($"Novo Saldo: {conta.Saldo:c}");
}
IConta c1 = new ContaCorrente(1000,"Vitor");
IConta p1 = new ContaPoupanca(790,"Clara");
RealizarSaque(c1,200);
c1.Depositar(250);
RealizarSaque(c1,250);

RealizarSaque(p1,300);
p1.Depositar(500);
RealizarSaque(p1,100);

