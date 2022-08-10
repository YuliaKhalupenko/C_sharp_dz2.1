//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine()!);

if(a > 0 && a <= 5) 
{
    Console.WriteLine("Это будний день");
}
else if(a > 5 && a <= 7) 
{
    Console.WriteLine("Это выходной день");
}
else Console.WriteLine("Такого номера дня недели нет");