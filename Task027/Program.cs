// 27. Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// Например: 452 -> 11,  82 -> 10,  9012 -> 12

Console.Write("Введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());
int result = DigitQuantity(number);
int DigitQuantity (int num)
{
    int counter = 0;
    while(num > 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}

if (result == 2)
{
    int sum2 = number % 10 + number / 10 % 10;
    Console.WriteLine($"Сумма цифр равна {sum2}");
}
if (result == 3)
{
    int sum3 = number % 10 + number / 10 % 10 + number / 100 % 10;
    Console.WriteLine($"Сумма цифр равна {sum3}");
}
if (result == 4)
{
    int sum4 = number % 10 + number / 10 % 10 + number / 100 % 10 + number / 1000 % 10;
    Console.WriteLine($"Сумма цифр равна {sum4}");
}

