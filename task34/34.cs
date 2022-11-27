//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте длину массива");
int userlenght = int.Parse(Console.ReadLine()!); 
int[] massive = GetArray(userlenght);
Console.WriteLine("Полученный массив:");
Console.Write("["+ string.Join(", ", massive)+ "]");//печатаем массив
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в Вашем массиве равно {QuantityEven(massive)}");

//Пишем функцию, которая составит нам массив, соответствующий заданным условиям
int[] GetArray (int lenght, int minValue = 100, int maxValue = 999)
{
    int[] array = new int[lenght];
    var rnd = new Random(); // объявление случайных числел
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue,maxValue+1);
    }
    return array; //получаем наш массив
}
//Функция для подсчета количества четных чисел
int QuantityEven(int[] array)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}
