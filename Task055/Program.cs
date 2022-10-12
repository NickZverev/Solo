// 55: Задайте двухмерный массив. Напишите программу, которая
// заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

int[,] myArray = CreateMatrix(4, 4, 1, 9);
PrintMatrix(myArray);
Console.WriteLine();
 
// Проверка массива на равенство размера строк и столбцов
bool CheckMatrix(int[,] myArray)
{
    return myArray.GetLength(0) == myArray.GetLength(1);
}

// Уведомление при невозможности замены строк и столбцов
if (CheckMatrix(myArray))
{
    PrintMatrix(ReplaceRowsColumns(myArray));
}
else Console.WriteLine("Нельзя заменить строки на столбцы");

// Метод замены в массиве строк на столбцы
int[,] ReplaceRowsColumns(int[,] matrix)
{
    int size = matrix.GetLength(0);
    int[,] newArray = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[i, j] = matrix[j, i];
        }
    }
    return newArray;
}

// Другой метод замены в массиве строк на столбцы
// void RewriteRowsToColumns (int [,] matrix) 
// {     
//     for (int i = 0; i < matrix.GetLength(0); i++)     
//     {         
//         for (int j = i; j < matrix.GetLength(1); j++)         
//         {             
//             int temporary = matrix [i, j];             
//             matrix[i, j] = matrix[j, i];             
//             matrix[j, i] = temporary;
//         }
//     }
// }

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
