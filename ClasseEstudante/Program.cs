using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime;
using ClasseEstudante;
internal class Program
{
    private static void Main(string[] args)
    {
        Estudante aluno1 = new Estudante();
        Console.Write("Digite o nome do aluno: ");
        aluno1.Nome = Console.ReadLine();
        Console.Write("Digite a média do aluno: ");
        aluno1.Media = Convert.ToDouble(Console.ReadLine());
        aluno1.MostrarAtributos();
        aluno1.ExibirInformações();

        Estudante aluno2 = new Estudante();
        Console.Write("Digite o nome do aluno: ");
        aluno2.Nome = Console.ReadLine();
        Console.Write("Digite a média do aluno: ");
        aluno2.Media = Convert.ToDouble(Console.ReadLine());
        aluno2.MostrarAtributos();
        aluno2.ExibirInformações();
        
    }
}