class Program
{
    static void Main(string[] args)
    {
        double radio;
        double perimetro;
        bool num;

        do
        {
            Console.Write("Indique el radio del círculo: ");
            string input = Console.ReadLine();
            
            
            num = double.TryParse(input, out radio);

            if (!num || radio <= 0)
            {
                Console.WriteLine("¡ERROR! Introduzca un valor numérico ");
                num = false; 
            }

        } while (!num);

    
        perimetro = 2 * Math.PI * radio;

        Console.WriteLine($"Para un círculo con radio {radio} el perímetro es: {perimetro}");
    }
}