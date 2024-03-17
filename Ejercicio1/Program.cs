using System;

class Program
{
    static void Main(string[] args)
    {
        double num = 0;
        double resultado = 0;

        while (true) 
        {
            Console.WriteLine("Ingresa un número:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out num))
            {
                if (num > 0)
                {
                    resultado = (num * num);
                    Console.WriteLine($"El cuadrado de {num} es: {resultado}");
                    break; 
                }
                else
                {
                    Console.WriteLine("¡ERROR! El número ingresado debe ser positivo.");
                }
            }
            
        }
    }

}
