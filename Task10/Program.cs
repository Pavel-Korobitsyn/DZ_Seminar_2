int InCenter(int number)
{   
    int result = ((number / 10) % 10);
    return result;
}

Console.WriteLine("Введите трёхзначное число");

int number = int.Parse(Console.ReadLine());
int size = number.ToString().Length;

if (size == 3 )
{
    Console.WriteLine(InCenter(number));
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");   
}
