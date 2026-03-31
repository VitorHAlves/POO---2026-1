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

        Produto prod3 = new Produto("Monitor",850);
        Produto prod4 = new Produto("Headset",100);

        Vendedor vend2 = new Vendedor();
        Comprador comp2 = new Comprador(1200);
        List<Produto> vetProd2;
        vetProd2 = new List<Produto>();

        vetProd2.Add (prod3);
        vetProd2.Add (prod4);
        Venda venda2 = new Venda (comp2,vend2,vetProd2);
        venda2.MostrarAtributos();
        
    }
}