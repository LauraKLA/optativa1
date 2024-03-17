class Program
{
    static void Main(string[] args)
    {

        int suma = 0;

        for (int i = 1; i <= 50; i++)
        {

            if (i % 2 == 0)
            {

                suma += i;
            }
        }

        Console.WriteLine("La suma de los números pares entre 1 y 50 es: " + suma);

    }
}
