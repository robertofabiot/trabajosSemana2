namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroActual = 0;
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número entero: ");
                numeroActual = Convert.ToInt32(Console.ReadLine());
                numeros[i] = numeroActual;
            }

            int pares = 0; int impares = 0;
            for(int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                    pares++;
                else
                    impares++;
            }
            Console.WriteLine($"La cantidad de números pares fue de: {pares}");
            Console.WriteLine($"La cantidad de números impares fue de: {impares}");
        }
    }
}
