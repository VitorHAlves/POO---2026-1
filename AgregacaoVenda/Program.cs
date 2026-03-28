using AgregacaoVenda;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto prod1 = new Produto("Mouse",50);
        Produto prod2 = new Produto("Teclado",200);

        Vendedor vend = new Vendedor();
        Comprador comp = new Comprador(1000);

        Venda venda1 = new Venda (comp,vend);
        venda1.VetProd.Add (prod1);
        venda1.VetProd.Add (prod2);
        double totalVenda1 = 0;
        foreach (var i in venda1.VetProd)
        {
            totalVenda1 += i.Preco;
        }
        comp.DiminuirVerba(totalVenda1);
        vend.CalcularComissao(totalVenda1);
        
        Console.WriteLine("Relatório da venda 1");
        venda1.MostrarAtributos();
        Console.WriteLine($"Total da Venda: {totalVenda1}");
        Console.WriteLine($"Verba restante: {comp.Verba}");
        Console.WriteLine($"Comissão do vendedor: {vend.Comissao}");
    }
}