// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 
//[-4, -6, 89, 6] -> 0
//Исходя из примеров ориентироваться надо на индекс: а0=3, а1=7,а2=23,а3=12 сумма а1+а3=7+12=19

Console.WriteLine("Задайте длину массива");
int userlenght = int.Parse(Console.ReadLine()!); 
int[] massive = GetArray(userlenght);
Console.WriteLine("Полученный массив:");
Console.Write("["+ string.Join(", ", massive)+ "]");//печатаем массив
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {SumEvenI(massive)}");

//Пишем функцию, которая составит нам массив, соответствующий заданным условиям
int[] GetArray (int lenght, int minValue = -100, int maxValue = 100)
{
    int[] array = new int[lenght];
    var rnd = new Random(); // объявление случайных числел
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue,maxValue+1);
    }
    return array; //получаем наш массив
}

//Функция для вычисления суммы элементов массива, стоящих на нечетных позициях (индекс которых является нечетным числом)

int SumEvenI(int[] array)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if (i !=0 & i % 2 != 0) count += array[i];
    }
    return count;
}
