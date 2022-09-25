// Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго
// Например:   a = 25, b = 5 -> да    а = 2, b = 10 -> нет
//             а = 9, b = -3 -> да    ф = -3, b = 9 -> нет

Console.Write("Введите первое число: ");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int namber2 = Convert.ToInt32(Console.ReadLine());
int square = namber2 * namber2;
if (namber1 == square)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

