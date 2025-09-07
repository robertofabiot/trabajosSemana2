namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0; int i = 1;
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
                i++;
            } while (i <= 10);
        }
    }
}
