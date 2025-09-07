//En una ferretería (PVC conduit SCH40, accesorios), el cajero ingresa cantidades y precios desde teclado.
//Se pueden ingresar textos no numéricos o números fuera de rango.

Console.WriteLine("SISTEMA DE FACTURADO DE FERRETERÍA");

//Pida cantidad (int) y precioUnitario (decimal).
int cantidad = 0;
decimal precioUnitario = 0;

while (true)
{
    try
    {
        Console.Write("Ingrese la cantidad: ");
        cantidad = Convert.ToInt32(Console.ReadLine());
        
        if (cantidad <= 0)
        {
            throw new FormatException();
        }

        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, ingrese un número entero válido.");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"El valor máximo es {int.MaxValue}");
    }
}

while (true)
{
    try
    {
        Console.Write("Ingrese el precio unitario: ");
        precioUnitario = Convert.ToDecimal(Console.ReadLine());

        if (precioUnitario <= 0)
        {
            throw new FormatException();
        }

        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, ingrese un número entero válido.");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"El valor máximo es {decimal.MaxValue}");
    }
}

decimal subtotal = cantidad * precioUnitario;
decimal iva = subtotal * 0.15m;
decimal total = subtotal + iva;

Console.WriteLine($"Subtotal: C${subtotal:F2}");
Console.WriteLine($"IVA: C${iva:F2}");
Console.WriteLine($"Total: {total:F2}");