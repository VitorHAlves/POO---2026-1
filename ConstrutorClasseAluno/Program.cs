using System.Reflection;
using ConstrutorClasseAluno;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("Vitor");
        aluno1.MostrarAtributos();
        Aluno aluno2 = new Aluno("Vitor Hugo");
        aluno2.MostrarAtributos();
        Aluno aluno3 = new Aluno("Maria Clara");
        aluno3.MostrarAtributos();
        Console.WriteLine($"Número de alunos cadastrados: {Aluno.Contador}");
    }
}