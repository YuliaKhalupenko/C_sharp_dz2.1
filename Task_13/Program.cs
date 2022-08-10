//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

while (a > 999)
{
a = a / 10;
}
if (a < 100) 
{
Console.WriteLine("третьей цифры нет");
}
else Console.WriteLine($"третья цифра числа {a} равна {a % 10}");