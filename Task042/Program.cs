// 42. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное. 13->1101,  3->11,  2->10

// Console.Write("Введите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// int binaryNum = ConvertNumberToBinary(number);
// Console.WriteLine($"{number} -> {binaryNum}");

// int ConvertNumberToBinary (int num)
// {
//     int binNum = default;
//     int count = 1;
//     while (num > 0)
//     {
//         binNum = binNum + num % 2 * count;
//         count = count * 10;
//         num = num / 2;
//     }
//     return binNum;
// }

// Решение задачи 42 методом РЕКУРСИИ
Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
DecToBin(number);

void DecToBin(int num)
{
    if (num == 0) return;
    DecToBin(num / 2);  
    Console.Write(num % 2);
    // DecToBin(num / 2); - При переносе в конец
    // метод выдаёт результат с разворотом числа
}