using AbstratoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Assalariado a1 = new Assalariado(1,"ana",1000);
        Assalariado a2 = new Assalariado(2,"Vitor",1000);
        Assalariado a3 = new Assalariado(3,"Clara",1000);

        Comissionado c1 = new Comissionado(4,"Leo",1000,20);
        Comissionado c1 = new Comissionado(5,"Pedro",1000,30);
        Comissionado c1 = new Comissionado(6,"Giovanna",1000,15);
    }
}