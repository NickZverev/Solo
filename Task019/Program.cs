// 19. Напишите программу, котора на вход принимает
// пятизначное число и проверяет, является ли оно
// полиндромом.  14212->нет,  23432->да,  12821->да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool res1 = number / 10000 == number % 10;
bool res2 = number / 1000 % 10 == number % 100 / 10;

if (res1 = res2) Console.WriteLine("да");
else Console.WriteLine("нет");