class Program
{
    static void Main(string[] args)
    {
      
        int numerador1, denominador1, numerador2, denominador2;

        
        while (true)
        {
            Console.Write("Ingrese el numerador de la primera fracción: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out numerador1))
                break;
            else
                Console.WriteLine("¡ERROR! el valor ingresado en este campo debe ser numérico.");
        }


        while (true)
        {
            Console.Write("Ingrese el denominador de la primera fracción: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out denominador1) && denominador1 != 0)
                break;
            else
                Console.WriteLine("¡ERROR! el valor ingresado en este campo debe ser numérico y diferente de 0.");
        }

      
        while (true)
        {
            Console.Write("Ingrese el numerador de la segunda fracción: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out numerador2))
                break;
            else
                Console.WriteLine("¡ERROR! el valor ingresado en este campo debe ser numérico.");
        }

      
        while (true)
        {
            Console.Write("Ingrese el denominador de la segunda fracción: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out denominador2) && denominador2 != 0)
                break;
            else
                Console.WriteLine("¡ERROR! el valor ingresado en este campo debe ser numérico y diferente de 0.");
        }


        double diferencia = (double)(numerador1 * denominador2 - numerador2 * denominador1) / (denominador1 * denominador2);

    
        Console.WriteLine($"La diferencia entre las fracciones {numerador1}/{denominador1} y {numerador2}/{denominador2} es: {diferencia}");

    }
}
