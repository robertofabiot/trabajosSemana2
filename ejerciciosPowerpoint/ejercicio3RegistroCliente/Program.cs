Console.WriteLine("REGISTRO DE CLIENTE");

string nombreCliente = "";
string numeroWhatsapp = "";

while (true)
{
    try
    {
        Console.Write("Ingrese su nombre completo: ");
        nombreCliente = Console.ReadLine();
        nombreCliente = (nombreCliente.Length == 0) ? null: nombreCliente.Trim().ToUpper();

        if (nombreCliente == null)
        {
            throw new NullReferenceException();
        }
        break;
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("El nombre no puede estar vacío");
    }
}

while (true)
{
    try
    {
        Console.Write("Ingrese su número de whatsapp, sin guiones ni código de país: ");
        numeroWhatsapp = Console.ReadLine();

        if (numeroWhatsapp.Length != 8)
        {
            throw new FormatException();
        }
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Ingrese un número válido, con 8 dígitos.");
    }
}

Console.WriteLine($"Nombre: {nombreCliente}");
Console.WriteLine($"Número de WhatsApp: {numeroWhatsapp}");