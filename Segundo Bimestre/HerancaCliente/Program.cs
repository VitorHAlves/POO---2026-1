using HerancaCliente;
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente c1 = new Cliente();
        c1.Codigo = 1;
        c1.Nome = "Ana";
        c1.MostrarAtributos();

        
        ClienteFisico cf = new ClienteFisico();
        cf.Codigo = 2;
        cf.Nome = "Vitor";
        cf.Rg = 100;
        cf.MostrarAtributos();

        ClienteFisico cf2 = new ClienteFisico(22,"Pedro",22);
        cf2.MostrarAtributos();

        ClienteJuridico cj =new ClienteJuridico();
        cj.Codigo = 3;
        cj.Nome = "Daniel";
        cj.Cnpj = 101;
        cj.MostrarAtributos();

        ClienteJuridico cj2 = new ClienteJuridico(33,"Empresa SA",33);
        cj2.MostrarAtributos();
    }
}