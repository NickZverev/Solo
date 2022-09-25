// Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число больше, а какое меньше

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} - большее, {num2} - меньшее");
}
else
{
    Console.WriteLine($"{num2} - большее, {num1} - меньшее");
}

