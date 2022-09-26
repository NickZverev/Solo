// 30. Напишите программу, которая выводит массив 
// из 8 элементов, заполняемый нулями и единицами 
// в случайном порядке.  [1,0,1,1,0,1,0,0]
//       Способы вызова:
// int[] array1 = new int[8] {1,2,3,4,5,6,7,8};
// int[] array2 = {1,2,3,4,5,6,7,8};
// var array3 - new int [8];

int[] array = new int [8];
GetArray(array);
PrintArray(array);

void GetArray(int[] arr)
{
    int length = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

