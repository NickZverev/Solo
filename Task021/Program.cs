// 21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 3D пространстве
// А (3, 6, 8); В (2, 1, -7) -> 15,84
// А (7,-5, 0); В (1, -1, 9) -> 11,53

Console.WriteLine("Введите координаты точки A ");
Console.Write("X1:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1:  ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");
Console.Write("X2:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2:  ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance(double argX1, double argY1, double argZ1, 
                double argX2, double argY2, double argZ2)
{
    double res = Math.Sqrt(Math.Pow((argX2 - argX1), 2)
                         + Math.Pow((argY2 - argY1), 2)
                         + Math.Pow((argZ2 - argX1), 2));
    return res;
}

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
