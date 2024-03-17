class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int minimo = int.MaxValue;

        Console.WriteLine("Ingresa cinco números:");

        while (contador < 5)
        {
            Console.Write($"Número {contador + 1}: ");
            string input = Console.ReadLine();
            int numero;

            if (int.TryParse(input, out numero))
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }

                contador++;
            }
            else
            {
                Console.WriteLine("¡ERROR! este campo debe ser numérico. Intenta nuevamente!");
            }
        }

        Console.WriteLine($"El número más pequeño es: {minimo}");
    }
}
