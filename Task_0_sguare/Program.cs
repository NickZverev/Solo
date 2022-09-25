// Напишите программу, которая на вход принимает число
// и выдаёт его квадрат (число, умноженное на само себя)
// Например:    4 -> 16,    -3 -> 9,    -7 -> 49

Console.Write("Введите целое число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int sguare = namber * namber;
Console.WriteLine($"Квадрат числа {namber} = {sguare}");
