// 50. Напишите программу, которая на вход принимает позиции
// элемента в двухмерном массиве и возвращает значение этого
// элемента или же даёт указание, что такого элемента нет.
//     Например, задан массив:     1    4    7    2 
//                                 5    9    2    3
//                                 8    4    2    4 
//                     1, 7 -> такого элемента в массиве нет
// ВНИМАНИЕ: выход из массива прекратит работу программы!!!           

Console.Write("Введите строку элемента:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

void FindElement(int[,] matrix, int rows, int columns)
{
    if (matrix.GetLength(0) < row && matrix.GetLength(1) < column)
        Console.Write("Такого элемента в массиве нет");
    else Console.Write($"Элемент = {matrix[row - 1, column - 1]}");
}

// Метод создания двухмерного массива случайными числами
int[,] CreateMatrix(int rows, int columns, int min, int max) 
{     
    int[,] matrix = new int[rows, columns];     
    var rnd = new Random();      
    
    for (int i = 0; i < matrix.GetLength(0); i++)     
    {   
        for (int j = 0; j < matrix.GetLength(1); j++)  
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

int[,] myArray = CreateMatrix(3, 4, 0, 9);
PrintMatrix(myArray);
FindElement(myArray, row, column);