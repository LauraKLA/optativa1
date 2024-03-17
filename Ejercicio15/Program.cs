class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        bool esNumeroValido = false;

        while (!esNumeroValido)
        {
            Console.Write("ingrese un número: ");
            string input = Console.ReadLine();

            esNumeroValido = int.TryParse(input, out numero);

            if (!esNumeroValido)
            {
                Console.WriteLine("¡ERROR! este campo permite sólo valores numéricos.");
                continue; 
            }
            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine($"¡ES CORRECTO! el número {numero} está entre 10 y 20. ");
            }
            else
            {
                Console.WriteLine($"¡ERROR! el número {numero} no está entre 10 y 20. Intenta de nuevo!");
                esNumeroValido = false; 
            }
        }
    }
}
