// Un grupo de estudiantes de la UAM viaja a León para una visita técnica. Deben repartir equitativamente los costos (combustible, peajes, refrigerios)
//Si nadie confirmó asistencia (0 participantes), el cálculo por persona falla.

//Solicite: costo total (C$) y número de participantes.
decimal costoTotal, costoPorPersona = 0;
int numeroParticipantes = 0;


Console.WriteLine("Vamos a calcular el costo por persona de la visita técnica.");
Console.Write("Ingrese el costo total: ");
costoTotal = Convert.ToDecimal(Console.ReadLine());

while (true)
{
    try
    {
        Console.Write("Ingrese el número de participantes: ");
        numeroParticipantes = Convert.ToInt32(Console.ReadLine());
        costoPorPersona = costoTotal / numeroParticipantes;
        break;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("No puede dividir entre cero. Regrese a primaria.");
    }
}

Console.WriteLine($"El costo por participante es {costoPorPersona}");