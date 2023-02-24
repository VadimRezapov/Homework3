//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int chislo = int.Parse(Console.ReadLine()!);
if (9999 < chislo & chislo < 100000)
{
    if (chislo / 10000 == chislo % 10 & (chislo / 1000) % 10 == (chislo / 10) % 10) Console.WriteLine($"Число {chislo} является полиндромом");
    else Console.WriteLine($"Число {chislo} не является полиндромом");
}
else Console.WriteLine("Введено не пятизначное число");