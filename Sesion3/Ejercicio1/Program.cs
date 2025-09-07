namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular el iva del precio de un producto
            double precio, iva, monto;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Precio: ");
            precio = Convert.ToDouble(Console.ReadLine());
            iva = precio * 0.15;
            monto = precio + iva;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"IVA: {iva}");
            Console.WriteLine($"Monto: {monto}");
            Console.ResetColor();
        }
    }
}
