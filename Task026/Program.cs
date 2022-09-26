// 26/ Напишите программу, которая принимает на вход число и
// выдайт количество цифр в числе

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = DigitQuantity(number);
Console.WriteLine($"В числе {number} - {result} цифр ");
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
