class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.WriteLine("Ingrese el primer número:");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("¡ERROR! este campo sólo permite carácter numérico. Intente nuevamente.");
        }

        Console.WriteLine("Ingrese el segundo número:");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("¡ERROR! este campo sólo permite carácter numérico. Intente nuevamente.");
        }

        if (num2 != 0)
        {
            int residuo = num1 % num2;
            Console.WriteLine($"El residuo de la división de {num1} entre {num2} es: {residuo}");
        }
        else
        {
            Console.WriteLine("¡ERROR!: No se puede dividir entre cero.");
        }
    }
}