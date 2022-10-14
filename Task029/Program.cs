// 29. Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран. 
// 1,2,5,7,19,6,1,33 -> [1,2,5,7,19,6,1,33]


int[] arr = CreateArrayRndInt(8, 0, 99); 
PrintArray(arr);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


