// 5. Напишите программу, которая на вход принимает одно
// число (N), а на выходе показывает все целяе числа в 
// промежутке от (-N) до (N).

int num = Convert.ToInt32(Console.ReadLine());
int counter = - num;
while (counter <= num)
{
    Console.Write($"{counter} ");
    counter++;
}

