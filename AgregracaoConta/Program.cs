using AgregracaoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cli = new Cliente();
        cli.Nome = "Ana";
        cli.Rg = 131313;
        cli.Telefone = 9999;

        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Saldo = 1500;
        c1.Titular = cli;//Titular é um atributo/propriedade
        //quando ele recebe um objeto, ele também vira um objeto.
        // e efetiva a agregação

        Conta c2. = new Conta();
        c2.Numero = 2;
        c2.Saldo = 3400;
        c2.Titular = new Cliente();
        c2.Titular.Nome = "Bia";
        c2.Titular.Rg = 100;
        c2.Titular.Telefone = 41;    
    }
}