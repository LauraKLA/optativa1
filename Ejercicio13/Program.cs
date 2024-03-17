class Program
{
    static void Main(string[] args)
    {
        string palabra;

        Console.WriteLine("Ingresa una palabra:");
        
        while (true)
        {
            palabra = Console.ReadLine();
            if (!ContieneNumeros(palabra))
                break;
            Console.WriteLine("¡ERROR! este campo solo permite texto. Intente nuevamente!");
        }

        int numeroVocales = contarVocales(palabra);

        Console.WriteLine($"La palabra \"{palabra}\" tiene {numeroVocales} vocales.");
    }

    static int contarVocales(string palabra)
    {
        int count = 0;
        foreach (char c in palabra.ToLower())
        {
            if ("aeiouáéíóú".Contains(c))
            {
                count++;
            }
        }
        return count;
    }

    static bool ContieneNumeros(string input)
    {
        foreach (char c in input)
        {
            if (char.IsDigit(c))
                return true;
        }
        return false;
    }
}