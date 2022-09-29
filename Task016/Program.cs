// 16. Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число квадратом
// другого. 5, 25 - да  -4, 16 - да  25, 5 - да  8, 9 - нет

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare(int arg1, int arg2)
{
    return arg1 == arg2 * arg2 || arg2 == arg1 * arg1;
}
bool result = IsSquare(number1, number2);

if (result) Console.WriteLine($"{number1}, {number2} => Да!");
else Console.WriteLine($"{number1}, {number2} => Нет!");