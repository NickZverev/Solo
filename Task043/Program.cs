// 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// у = k1 * х + b1, у = K2 * х + b2; значения
// b1, K1, b2 и K2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1:\t");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1:\t");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2:\t");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2:\t");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = Math.Round(Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2), 1);
double y = Math.Round(Convert.ToDouble(k1) * Convert.ToDouble(x) + Convert.ToDouble(b1), 1);

Console.WriteLine($"Координаты пересечения прямых: x = {x}, y = {y}");


