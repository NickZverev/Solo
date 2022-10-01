// 23. Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27       5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

void SquareTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"|{counter, 3}|{counter * counter * counter, 3}|");
        counter++;
    }
}
if (num > 0) SquareTable(num);
else Console.WriteLine("Введено некорректное значение");
