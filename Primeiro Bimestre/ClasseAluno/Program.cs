using ClasseAluno;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.MostrarAtributos();

        Console.Write("Digite o RA do aluno: ");
        aluno1.ra = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do aluno: ");
        aluno1.nome = Console.ReadLine();

        Console.Write("Digite a nota da P1 do aluno: ");
        aluno1.p1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a nota da P2 do aluno: ");
        aluno1.p2 = Convert.ToInt32(Console.ReadLine());
        aluno1.CalcularMedia();
        aluno1.MostrarAtributos();

        Aluno aluno2 = new Aluno();
        aluno2.MostrarAtributos();

        Console.Write("Digite o RA do aluno: ");
        aluno2.ra = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do aluno: ");
        aluno2.nome = Console.ReadLine();

        Console.Write("Digite a nota da P1 do aluno: ");
        aluno2.p1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a nota da P2 do aluno: ");
        aluno2.p2 = Convert.ToInt32(Console.ReadLine());
        aluno2.CalcularMedia();
        aluno2.MostrarAtributos();
    }
}