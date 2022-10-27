// 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число:\t"); 
int number = Convert.ToInt32(Console.ReadLine()); 
int sum = DigitSumInNumber(number); 
Console.WriteLine(sum);  

int DigitSumInNumber(int num)  
{
    int sumOfDigits = num % 10;      
    if (num > 0) sumOfDigits += DigitSumInNumber(num / 10); 
    return sumOfDigits;
}
