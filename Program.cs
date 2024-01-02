namespace Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celcius por favor: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("A temperatura equivalente em Fahrenheit é: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir??? (Digite s ou n) : ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');

            Console.ReadLine();
        }
    }
}