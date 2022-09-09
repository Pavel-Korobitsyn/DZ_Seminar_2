Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else Console.WriteLine("Этот день не выходной");
