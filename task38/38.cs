// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Задайте длину массива");
int userlenght = int.Parse(Console.ReadLine()!); 
double [] massive = GetArray(userlenght);
Console.WriteLine("Полученный массив:");
Console.Write("["+ string.Join(", ", massive)+ "]");//печатаем массив
Console.WriteLine();
Console.WriteLine($"Разница максимального элемента и минимального  элемента равна: {DifMaxMin(massive)}");

double[] GetArray (int lenght, int minValue = -100, int maxValue = 100)
{
    double[] array = new double[lenght];
    var rnd = new Random(); // объявление случайных числел
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue,maxValue+1);
    }
    return array; 
}

//Функция для вычисления разницы максимального и минимального элемента массива

double DifMaxMin(double[] array)
{
    double max = array[0];
    double min = array[1];
    if (max < min)
        {
            max = array[1];
            min = array[0];
        } 
      
    for (int i = 2; i <array.Length; i++)
    {
        if (array[i]> max) max = array[i];
        else if (array [i] < min) min = array[i];
    }
    double dif = max - min;
    return dif;
}
