﻿// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно
// числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно.

Console.Write("Введите первое число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsAliquot(int arg1, int arg2)
{
    return arg1 % arg2 == 0;
}
bool result = IsAliquot(num1, num2);
if (result) Console.WriteLine($"{num1} кратно {num2} ");
else Console.Write($"{num1} не кратно {num2} Остаток: {num1 % num2}");