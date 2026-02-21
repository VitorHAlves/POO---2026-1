internal class Program
{
    private static void Main(string[] args)
    {
   /* 
        Console.Write("Digite o ano de nascmento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        int idade = 2026 - ano;
        Console.WriteLine($"Sua idade é: {idade}");
        if (idade >= 18)
        {
            Console.WriteLine("Pode tirar habilitação");
        }
        else if(idade == 0)
        {
            Console.WriteLine("Nunca vai tirar habilitação");
        }
        else
        {
            Console.WriteLine("Não pode tirar habilitação");
        }

        switch (idade) //switchcase é usado pra tratar com igualdade (==)
        {
            case 18: Console.WriteLine("Pode dirigir");
            break;

            case 17: Console.WriteLine("Não pode");
            break;

            default: Console.WriteLine("Não tem permissão");
            break;
        }
        while (contador <= 10)
        {
            Console.WriteLine($"{tabuada} x {contador} = {tabuada*contador}");
            contador++;
        }
        for(int i=1; i<=10; i++)
        {
           Console.WriteLine($"{tabuada} x {i} = {tabuada*i}"); 
        }
        */
        //Estrutura de repetição do ..while
        int tabuada = 6;
        int contador = 1;
        do 
        {
            Console.WriteLine($"{tabuada} x {contador} = {tabuada*contador}");
            contador++;
        } while(contador<=10);
            
        
    }
}