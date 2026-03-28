using AgregacaoVenda;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto prod = new Produto("Mouse",50);
        prod.MostrarAtributos();

        Produto prod2 = new Produto("Teclado",200);
        prod2.MostrarAtributos();

        Vendedor vend = new Vendedor();
        vend.CalcularComissão(100);
        vend.MostrarAtributos();

        Comprador comp = new Comprador (1000);
        comp.MostrarAtributos();
        comp.DiminuirVerba(100);
        comp.MostrarAtributos();

        Venda venda1 = new Venda(comp,vend);
        venda1.VetProd.Add(prod);
        venda1.MostrarAtributos();
    }
}