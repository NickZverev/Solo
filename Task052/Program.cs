// 52. Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждос столбце.
//     Например, задан массив:     1    4    7    2 
//                                 5    9    2    3
// Среднее арифметическое          8    4    2    4 
//         каждого столца:        4,6  5,6  3,6   3     


int[,] myArray = CreateMatrix(3, 4, 1, 9);
PrintMatrix(myArray);
Console.WriteLine();
PrintArray(AverageSumEachColumn(myArray));

// Метод вычисления средней суммы по столбцам
double[] AverageSumEachColumn(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double sum = default;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        double average = sum / matrix.GetLength(0);
        array[i] = Math.Round(average, 1, MidpointRounding.ToZero);
        sum = 0;
    }
    return array;
}

// Метод вывода результата вычислений для типа "double"
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},  ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

// Метод создания двухмерного массива.
int[,] CreateMatrix(int rows, int columns, int min, int max) 
{     
    int[,] matrix = new int[rows, columns];     
    var rnd = new Random();      
    
    for (int i = 0; i < matrix.GetLength(0); i++)  //rows (0)     
    {   
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Метод печати двухмерного массива.
void PrintMatrix(int[,] matrix) 
{     
    for (int i = 0; i < matrix.GetLength(0); i++)     
    {         
        Console.Write("|");         
        for (int j = 0; j < matrix.GetLength(1); j++)         
        {             
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("|");
    }
}
