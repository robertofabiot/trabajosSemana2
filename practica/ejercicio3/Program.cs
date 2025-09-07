namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("Seleccione la opción que desea realizar ingresando el número.");
            Console.WriteLine("1. Saludar.");
            Console.WriteLine("2. Mostrar la fecha actual.");
            Console.WriteLine("3. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola!");
                    break;
                case 2:
                    Console.WriteLine($"{DateTime.Today.ToString("d")}");
                    break;
                case 3:
                    Console.WriteLine("Adiós");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}
