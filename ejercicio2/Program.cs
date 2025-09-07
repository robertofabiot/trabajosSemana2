namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, suma = 0;
            Console.Write("Ingrese un número entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i <= numero)
            {
                suma += i;
                i++;
            }
            Console.WriteLine($"La suma desde 1 hasta {numero} es {suma}");
        }
    }
}
