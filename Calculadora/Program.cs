internal class Program
{
    private static void Main(string[] args)
    {
        float n1, n2;
        Console.WriteLine("Informe o primeiro número: ");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        n2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Soma: " + (n1 + n2));
        Console.WriteLine("Subtração: " + (n1 - n2));
        
        if(n2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero!");
        }
        else
        {
            Console.WriteLine("Divisão: " + (n1 / n2).ToString("F2"));
        }
        Console.WriteLine("Multiplicação: " + (n1 * n2));
        Console.ReadKey();

    }
}