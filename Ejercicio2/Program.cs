class Program
{
    static void Main(string[] args)
    {

        int resultado;

        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());


        if (num1 > num2)
        {
            resultado = num1 * 2;
        }
        else
        {
            resultado = num2 * 3;
        }

        Console.WriteLine("El resultado es: " + resultado);

    }
}
