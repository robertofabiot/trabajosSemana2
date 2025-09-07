namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "admin1234";
            string intentoContraseña = "";

            while (contraseña != intentoContraseña)
            {
                Console.Write("Ingrese la contraseña (es admin1234): ");
                intentoContraseña = Console.ReadLine();
            }
            Console.WriteLine("Nice");
        }
    }
}
