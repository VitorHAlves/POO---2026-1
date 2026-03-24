using AgregacaoVetorConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cli1 = new Cliente();
        cli1.Nome = "Ana";
        cli1.Rg = 111;
        cli1.Telefone = 434;

        Cliente cli2 = new Cliente();
        cli2.Nome = "Pedro";
        cli2.Rg = 444;
        cli2.Telefone = 777;

        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Saldo = 10000;
        c1.VetTitular = new List<Cliente>();//sintaxe List
        c1.VetTitular.Add(cli1);
        c1.VetTitular.Add(cli2);
        c1.MostrarAtributos();
        foreach (var item in c1.VetTitular)
        {
            item.MostrarAtributos();
        }
    }
}