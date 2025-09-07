namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de días: "); int dias = Convert.ToInt32(Console.ReadLine()); Console.WriteLine($"{dias / 7} semanas y {dias % 7} días");
        }
    }
}
