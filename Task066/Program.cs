// 66: Задайте значения М и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от М до N.
// М = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите значение M:\t");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:\t");
int n = Convert.ToInt32(Console.ReadLine());

// Проверка корректности введённых значений
if(m > n)
{
    int temp = m;
    m = n;
    n = temp;
}
Console.Write($"Проверка значения М:\t{m}");
Console.WriteLine();
Console.Write($"Проверка значения N:\t{n}");

int sum = SumRec(m, n);
Console.WriteLine();
Console.Write($"Сумма чисел от M до N = {SumRec(m, n)}");

int SumRec(int m, int n)
{
    if(n == m) return m;
    else return n + SumRec(m, n - 1);
}