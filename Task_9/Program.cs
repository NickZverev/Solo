﻿// 9. Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую
// цифру числа. Например: 78 -> 8  12 -> 2  85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}"); //строку можно убрать.
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit == secondDigit) Console.WriteLine("цифры равны");
else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} = {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");