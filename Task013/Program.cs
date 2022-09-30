// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// Например: 645->5, 78->третьей цифры нет, 32679->6

Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 1000)        
{
    int counter = 0;
    number = number / 10;
    counter++;
}
int result = number % 10;

if (number >= 100)
{
    Console.Write($"Третья цифра  ->  {result}");
}
else
Console.Write("Третьей цифры нет");