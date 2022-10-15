// 25. Напишите цикл, который принимает на вход два числа
// (А и В) и возводит число А в натуральную степень В.
// Например:  3, 5 -> 243 (3 в 5 степени)     2, 4 -> 16

Console.Write("Введите основание степени А   ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени B  ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int a, int b)
{
    int count = 1;
    int res = a;
    while (count < b)
    {
        if (count < b)
        {
            res = res * a;
        }
        count++;
    }
    return res;     
}

int result = Exponentiation(a, b);
Console.Write($"A в натуральной степени B  = {result} ");
