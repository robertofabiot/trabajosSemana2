namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCalificaciones = 0;
            Console.Write("Ingrese el número de calificaciones: ");
            numCalificaciones = Convert.ToInt32(Console.ReadLine());
            int[] calificaciones = new int[numCalificaciones];

            int i = 0; int calificacionActual = 0;
            while (i < numCalificaciones)
            {
                Console.Write($"Ingrese la calificación {i+1}: ");
                calificacionActual = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = calificacionActual;
                i++;
            }

            double promedioFinal = calificaciones.Sum() / numCalificaciones;

            Console.WriteLine($"El promedio final es {promedioFinal}");
        }
    }
}
