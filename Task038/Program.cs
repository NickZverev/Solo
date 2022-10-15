// 38. Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
 
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] DifferenceMinMax(double[] array)
{   
    double max = array[0]; 
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Элемент массива: max = {max}");

    double min = array[0];       
    for (int i = 1; i < array.Length; i++)     
    {         
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Элемент массива: min = {min}");

    double diff = max - min; 
    Console.WriteLine($"Разница:  max - min  = {diff}");
    return new double[] {diff};
} 

double[] arr = CreateArrayRndDouble(5, 0, 99); 
PrintArray(arr); 
double[] diff = DifferenceMinMax(arr);
