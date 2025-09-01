float num1, num2;
float division;

Console.Write("Digite un núnmero: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Digite otro número: ");
num2 = float.Parse(Console.ReadLine());

try
{
    division = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {division}");
}
catch(DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre 0");
}