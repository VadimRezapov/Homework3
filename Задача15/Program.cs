// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Clear();

Console.WriteLine("Введите цифрц от 1 до 7:");
int week = int.Parse(Console.ReadLine()!);

if (week > 0 && week < 6)
{
    Console.WriteLine("Не выходной, идем в школу");

}
else if (week == 6 || week == 7)
{
    Console.WriteLine("Выходной, идем гулять с на улицу");
}
else
{
    Console.WriteLine("Не является выходым днем");
}
