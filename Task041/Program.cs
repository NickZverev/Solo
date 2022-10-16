// 41. Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2       -1, -7, 567, 89, 223 -> 3

int[] EnteringArrayElements(int size, int min, int max)
{
    Console.Write("Введите количество элементов массива:\t "); 
    int elementsCount = int.Parse(Console.ReadLine());
    int[] myArray = new int[elementsCount];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива c индексом {i}:\t "); 
        myArray[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Вывод массива: [");
    for (int i = 0; i < myArray.Length; i++)
    {
        if (i < myArray.Length - 1) Console.Write($"{myArray[i]}, ");
        else Console.Write($"{myArray[i]}");
    }
    Console.Write($"]");
    Console.WriteLine();

    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0) count = count + 1;
    }
    Console.Write($"Количество чисел больше нуля = {count}");
    Console.WriteLine();
    return new int[] {count};
}

int[] arr = EnteringArrayElements(5, -9, 9);
