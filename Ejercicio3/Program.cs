class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Ingresa un número: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double num))
                {
                    if (num >= 0)
                    {
                        double raizCuadrada = Math.Sqrt(num);
                        Console.WriteLine($"La raíz cuadrada de {num} es: {raizCuadrada}");
                    }
                    else
                    {
                        double cuadrado = Math.Pow(num, 2);
                        Console.WriteLine($"El cuadrado de {num} es: {cuadrado}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("¡ERROR! este campo es numérico, por favor ingrese un dato válido.");
                }
            }
            catch (Exception)
            {
               
            }
        }
    }
}

