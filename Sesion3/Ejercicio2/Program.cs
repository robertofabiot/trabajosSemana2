using System.Linq.Expressions;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular la nota de un estudiante que tiene 3 parciales los cuales se suman y se dividen entre 3. Decir si aprobo o reprobo. Un estudiante aprueba si su nota final es mayor o igual a 85.
            double notaFinal;

            double[] notas = new double[3];
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Ingrese la nota#{i + 1}: ");
                        notas[i] = Convert.ToDouble(Console.ReadLine());
                        if (notas[i] > 100 || notas[1] < 0)
                        {
                            throw new FormatException();
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nota inválida. Ingrese un número entre 0 y 100");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine($"Causa: {ex.InnerException?.Message}");
                    }
                }

            }
            notaFinal = notas.Sum() / 3;

            Console.WriteLine($"La nota final es {notaFinal}");

            if (notaFinal >= 85)
                Console.WriteLine("Aprobó");
            else
                Console.WriteLine("Reprobó");
        }
    }
}
