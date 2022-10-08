// 40. Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать 
// треугольник со сторонами такой длины.

Console.WriteLine("Введите стороны треугольника:");
int sideA = Convert.ToInt32(Console.ReadLine());
int sideB = Convert.ToInt32(Console.ReadLine());
int sideC = Convert.ToInt32(Console.ReadLine());
if (CanTriangleExite(sideA, sideB, sideC)) 
                Console.WriteLine($"Да, существует");
else Console.WriteLine($"Нет, не существует");

bool CanTriangleExite(int side1, int side2, int side3)
{
    return side1 + side2 > side3 && side2 + side3 
                > side1 && side1 + side3 > side2;
}
