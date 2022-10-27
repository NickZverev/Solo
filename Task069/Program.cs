// 69: Напишите программу, которая на вход принимает два числа
// А и В и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите основание:\t"); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите степень:\t"); 
int numberB = Convert.ToInt32(Console.ReadLine()); 
int powAtoB = PutAInPowerB (numberA, numberB); 
Console.WriteLine($"Число А в степени В =  {powAtoB}");   

int PutAInPowerB(int numA, int numB)  
{
    // if (numB == 0)  return 1;         //Вариант решения
    // return numA *= PutAInPowerB(numA, numB - 1);
    return  numB == 0 ? 1 : numA * PutAInPowerB(numA, numB - 1);    
}
