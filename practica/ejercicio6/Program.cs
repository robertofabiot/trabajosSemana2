namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else
            {
                Console.WriteLine("El número es 0");
            }
        }
    }
}
