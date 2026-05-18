//Main()
using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Leo", 1000, 20);
Comissionado c2 = new Comissionado(4, "Teo", 1000, 30);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.Listar();
Console.WriteLine($"Total {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
//d2.Demitir(2);
//d2.Listar();
Console.WriteLine($"Total {d2.CalcularFolha(30):c}");

