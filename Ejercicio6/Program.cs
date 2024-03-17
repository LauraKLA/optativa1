class Program
{
    static void Main(string[] args)
    {
        double salarioAnual = 0;
        bool esValido = false;


        while (!esValido)
        {
            Console.Write("Ingrese su salario anual: ");
            string input = Console.ReadLine();


            if (double.TryParse(input, out salarioAnual))
            {

                if (salarioAnual >= 0)
                {
                    esValido = true;
                }

            }
            else
            {
                Console.WriteLine("¡ERROR! el valor ingresado debe ser numérico.");
            }
        }


        if (salarioAnual > 12000)
        {
            double excedente = salarioAnual - 12000;
            double impuesto = excedente * 0.15;
            Console.WriteLine("El impuesto a pagar es: $" + " " + impuesto);
        }
        else
        {
            Console.WriteLine("No debe que pagar impuestos.");
        }
    }
}