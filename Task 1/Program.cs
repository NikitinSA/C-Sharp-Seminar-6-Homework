/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();

Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int PositiveNumber(int[] array, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

FillArray(array);
int result = PositiveNumber(array, size);
Console.Write($"Количество чисел, которые больше 0 = {result}");