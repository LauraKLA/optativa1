class Program
{
    static void Main(string[] args)
    {
        double suma = 0;
        int count = 0;
        
        Console.WriteLine("Ingrese cuatro números para calcular su promedio:");

        while (count < 4)
        {
            Console.Write($"Número {count + 1}: ");
            string input = Console.ReadLine();

            double number;
            if (double.TryParse(input, out number)) 
            {
                suma += number;
                count++;
            }
            else
            {
                Console.WriteLine("¡ERROR! los datos ingresados en este campo deben ser numéricos.");
            }
        }

        double average = suma / 4;
        Console.WriteLine($"la suma de los números ingresados es {suma} y el promedio es: {average}");
        
    }
}