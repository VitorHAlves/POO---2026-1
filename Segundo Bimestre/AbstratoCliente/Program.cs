using AbstratoCliente;
internal class Program
{
    private static void Main(string[] args)
    {
        Endereco e = new Endereco("Rua qualquer coisa",10,"Centro","SA");
        ClienteFisico cf = new ClienteFisico(1,"Vitor",40,3531);
        cf._Endereco = e;// propriedade que representa o endereço -> _

        Teste teste = new Teste();
        teste.AvaliarIdadeCliente(cf);
    }
}