using ExercicioOCP;
internal class Program
{
    private static void Main(string[] args)
    {
        FuncionarioPermanente fp = new FuncionarioPermanente("Vitor",1000);
        Console.WriteLine($"O salario é: {fp.CalcularSalario():c}");

        FuncionarioContrato fc = new FuncionarioContrato("Thiago",43);
        Console.WriteLine($"O salário é: {fc.CalcularSalario():c}");

    }
}