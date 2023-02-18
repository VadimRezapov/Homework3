// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Clear();

Console.WriteLine("Введите любое число больше 99 или меньше -99:");
int tree = int.Parse(Console.ReadLine()!);

int n = 1;
int tree2 = 0;

if (tree2 <0)
{
    tree = -tree2;
}
if (tree / 99 > 0)
{
    while (tree / n > 99)
    {
        n = n * 10;
    }
        tree2 = (tree / n) % 10;
        Console.WriteLine(tree2);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
