using AgregacaoVenda;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto prod1 = new Produto("Mouse",50);
        Produto prod2 = new Produto("Teclado",200);

        Vendedor vend = new Vendedor();
        Comprador comp = new Comprador(1000);
        List<Produto> vetProd;
        vetProd = new List<Produto>();

        vetProd.Add (prod1);
        vetProd.Add (prod2);
        Venda venda1 = new Venda (comp,vend,vetProd);
        venda1.MostrarAtributos();
        
    }
}