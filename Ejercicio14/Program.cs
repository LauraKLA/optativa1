class Program
{
    static void Main()
    {
        int numero;
        
        Console.WriteLine("Ingrese un número entero positivo para calcular su factorial:");
        
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("¡ERROR! ingrese un número entero positivo:");
        }
        
        long factorial = CalcularFactorial(numero);
        
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
    static long CalcularFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        
        long factorial = 1;
        while (n > 0)
        {
            factorial *= n;
            n--;
        }
        
        return factorial;
    }
}
