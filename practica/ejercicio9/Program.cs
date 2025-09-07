namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            int i = 0; int numeroActual = 0;
            while (i < 3)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                numeroActual = Convert.ToInt32(Console.ReadLine());
                numeros[i] = numeroActual;
                i++;
            }

            int numeroMayor = numeros[0];
            int indiceMayor = 0;

            if (numeros[1] > numeroMayor)
            {
                numeroMayor = numeros[1];
                indiceMayor = 1;
            }

            if (numeros[2] > numeroMayor)
            {
                numeroMayor = numeros[2];
                indiceMayor = 2;
            }

            Console.WriteLine($"El mayor es {numeroMayor}");
        }
    }
}
