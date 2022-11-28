// Дополнительно. Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1.

int[] array = {1,15,96,52,29,3,89,89};
Console.WriteLine("Введите число, индекс котрого Вы хотите узнать");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Индекс искомого числа равен {IndexFound(array)}");

int IndexFound(int[] array)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) index = i;   
    }
    return index; 
    }