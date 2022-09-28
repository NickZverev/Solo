// 14. Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет,   46 -> нет,   161 -> да

Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsALiquot7and23(int arg)
{
    return arg % 7 == 0 && arg % 23 == 0;
}
bool result = IsALiquot7and23(number);

if (result) Console.WriteLine("Да!!!");
else Console.WriteLine("Нет!!!");