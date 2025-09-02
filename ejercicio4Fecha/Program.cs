using System.Globalization;

Console.WriteLine("MANEJO DE FECHAS DE ENTREGA");

string fechaString = "";
int conteoErrores = 0;
DateTime fechaFormato;

//Solicite: fecha de entrega en formato dd/MM/yyyy.
//Valide la fecha con ParseExact dentro de un try-catch; ante error, muestre mensaje claro y registre el incidente.

while (true)
{
    try
    {
        Console.Write("Ingrese fecha de entrega en formato dd/mm/yyyy: ");
        fechaString = Console.ReadLine();
        fechaFormato = DateTime.ParseExact(fechaString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Ingrese una fecha en formato dd/MM/yyyy. Por ejemplo, 04/10/2007");
    }
}

//(Opcional) Reintente con TryParseExact para prevenir excepciones y guiar al usuario.

if (DateTime.TryParseExact(fechaString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaFormato))
{
    Console.WriteLine("Registro exitoso.");
}
else
{
    Console.WriteLine("Conversión fallida.");
}

Console.WriteLine($"Fecha registrada: {fechaFormato}");