// 24. Напишите программу, которая
// 1. принимает на вход число (А) и
// 2. выдаёт сумму чисел от 1 до А.
//    7 -> 28,   4 -> 10,   8 -> 36

Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int sumResult = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumResult}");

int SumNumbers(int num)   // Применять при заранее известном
{                         // числе итераций
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;  
}

int SumNumbers2(int num)  // Применять, когда число итераций и
{                         // условия выхода заранее не известны
    int sum = default; 
    int counter = 1;   
    while (counter <= num)
    {
        sum = sum + counter;
        counter++;
    }
    return sum;
}
