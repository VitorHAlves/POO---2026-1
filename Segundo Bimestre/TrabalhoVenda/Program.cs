using TrabalhoVenda;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>
            {
                new Produto(1, "Caneta Azul", 1.50, 200),
                new Produto(2, "Caderno", 12.90, 80),
                new Produto(3, "Borracha", 0.80, 500),
                new Produto(4, "Lápis", 0.60, 300),
            };
        Venda venda = new Venda (DateTime.Now.ToString("dd/MM/yyyy")); // coloquei isso pq deixei meus campos de data como string
        //não sabia outra forma de mexer com data
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("\n---MENU---");
            Console.WriteLine("1. Adicionar Item a Venda");
            Console.WriteLine("2. Ver venda Atual");
            Console.WriteLine("3. Finalizar Venda");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o código do produto: ");
                    long cod = Convert.ToInt64(Console.ReadLine());
                    Produto? produto = null;

                    foreach (var p in produtos)
                    {
                        if (p.Codigo == cod)
                        {
                            produto = p;
                            break;
                        }
                    }
                    if (produto == null)
                    {
                        Console.WriteLine("Produto não encontrado!");
                        break;
                    }

                    Console.Write("Quantidade: ");
                    int qtd = Convert.ToInt32(Console.ReadLine());

                    if (qtd > produto.Estoque)
                    {
                        Console.WriteLine("Estoque insuficiente!");
                        break;
                    }
                    venda.AdicionarItem(new ItemVenda(produto,qtd));
                    produto.Estoque -= qtd;
                    Console.WriteLine("Item adicionado!");
                    break;
                
                case "2":
                    if (venda.Itens.Count == 0)
                    {
                        Console.WriteLine("Nenhum item na venda!");
                        break;
                    }
                    venda.ImprimirCupom();
                    break;

            }
        }
    }

}

