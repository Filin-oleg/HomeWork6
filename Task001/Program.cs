// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("Сколько чисел Вы хотите ввести? ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arrayFill(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int Counter(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0)
        {
            count += 1;
        }
    }
    return count;
}
int[] arr = arrayFill(M);
Console.WriteLine($"Количество чисел больше 0 = " + Counter(arr));
