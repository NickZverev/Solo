// 53. Задайте двухмерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] myArray = CreateMatrix(3, 4, 1, 9);
PrintMatrix(myArray);
ReplaceFirstAndLastRow(myArray);
Console.WriteLine();
PrintMatrix(myArray);

// Поменять местами первую и последнюю строки массива
void ReplaceFirstAndLastRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int obj = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = obj;
    }
}

// Метод создания двухмерного массива случайными числами
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}