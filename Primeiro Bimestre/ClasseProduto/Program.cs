using System.Dynamic;
using ClasseProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        Produto bolacha = new Produto();
        Console.Write("Digite o código do produto: ");
        bolacha.codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do produto: ");
        bolacha.nome = Console.ReadLine();

        Console.Write("Digite o preço unitário do produto: ");
        bolacha.precoUnitario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o quantidade inicial de estoque do produto: ");
        bolacha.qtde = Convert.ToInt32(Console.ReadLine());

        bolacha.MostrarAtributos();
        bolacha.EstoqueMinimo();
    }
}