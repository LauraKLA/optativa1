class Program
{
    static void Main(string[] args)
    {
        int num;
        string diaSemana;

        do
        {
            Console.WriteLine("Ingrese un número del 1 al 7 para identificar el día de la semana:");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    diaSemana = "Lunes";
                    break;
                case 2:
                    diaSemana = "Martes";
                    break;
                case 3:
                    diaSemana = "Miércoles";
                    break;
                case 4:
                    diaSemana = "Jueves";
                    break;
                case 5:
                    diaSemana = "Viernes";
                    break;
                default:
                    diaSemana = "No laboral";
                    break;
            }

            if (num >= 1 && num <= 7)
            {
                Console.WriteLine("El día correspondiente al número ingresado es: " + diaSemana);
            }

        } while (num < 1 || num > 7);

       
    }
}
