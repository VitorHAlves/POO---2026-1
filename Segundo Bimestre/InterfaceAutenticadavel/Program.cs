using InterfaceAutenticadavel;
internal class Program
{
    private static void Main(string[] args)
    {
        //IAutenticavel ia = new IAutenticavel(); // <- da erro
        IAutenticavel ia;
        Gerente g = new Gerente();
        g.Senha = 123;
        ia = g;

        ia.Autenticar(123);
        Diretor d = new Diretor();
        d.Senha = 100;
        ia = d;
        ia.Autenticar(100);
        Cliente c = new Cliente();
        c.Senha = 244;
        ia = c;
        ia.Autenticar(244);

    }
}