Console.Write("Введи число: ");
string num1 = Console.ReadLine();
if (num1.Length > 2)
{
    Console.WriteLine($"Третья цифра {num1[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}