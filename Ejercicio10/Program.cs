class Program
{
    static void Main(string[] args)
    {
        string palabra;
        int longitud;

        do
        {
            Console.Write("Ingresa una palabra: ");
            palabra = Console.ReadLine().Trim();

            if (int.TryParse(palabra, out _))
            {
                Console.WriteLine("Este campo no es númerico, por favor ingresa una palabra.");
                continue;
            }
            else
            {
                longitud = palabra.Length;
                Console.WriteLine($"La longitud de la palabra '{palabra}' es: {longitud}");
                break;
            }
        } while (true);
    }
}