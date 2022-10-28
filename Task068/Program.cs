// 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2; n = 3 -> A(m, n) = 9
// m = 3; n = 2 -> A(m, n) = 29

Console.Write("Введите значение m:\t");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n:\t");
int n = Convert.ToInt32(Console.ReadLine());
int res = ARec(m, n);
Console.Write($"Результат вычисления =  {ARec(m, n)}");

int ARec(int m, int n)
{
    if(m == 0) return n + 1;
    else 
        if((m != 0) && (n == 0))
            return ARec(m - 1, 1);
        else
            return ARec(m - 1, ARec(m, n - 1));
}
