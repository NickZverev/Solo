// 25. Напишите цикл, который принимает на вход два числа
// (А и В) и возводит число А в натуральную степень В.
// Например:  3, 5 -> 243 (3 в 5 степени)     2, 4 -> 16

Console.Write("Введите число А  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B  ");
int number2 = Convert.ToInt32(Console.ReadLine());
int counter = 0;

double Exponentiation(int num1, int num2)
{
    double exponentiate = 1;
    while (counter < num2)
    {
        exponentiate = num1 * num1;
        counter++;
    }
    return exponentiate;
}

double exponentiateResult = exponentiate(number1, number1);
Console.WriteLine($"Возведение A {number1} в степень B {number2} = {exponentiateResult}");

Math