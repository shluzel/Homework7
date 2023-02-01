Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
string FindNumber(int[,] inArray, int Numb)
{
    int x = 0;
    int y = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == Numb)
            {
                x = i;
                y = j;
            }

        }
    }
    if (x == 0 && y == 0)
    {
        return ($"Элемента {Numb} в массиве нет.");
    }
    else {
        return ($"Элемент {Numb} стоит в массиве на {x} строке в {y} столбце");
    }

}
double [] AverageRows (int [,] inArray) {
    double [] res = new double [inArray.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum=sum+Convert.ToDouble(inArray[i,j]);
        }
        res [i] = sum/(inArray.GetLength(1));
    }
    return res;
}
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Введите количество строк массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
PrintArray(GetArray(columns, rows, -100, 100));
*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет. (В примере указан поиск числа по значению, а не позиции элемента)
/*
int[,] NewArray = GetArray(10, 10, -100, 100);
Console.WriteLine("Введите число, которое хотите найти в массиве: ");
PrintArray(NewArray);
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumber(NewArray, Number));
*/
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] NewArray = GetArray(4, 5, -10, 10);
Console.WriteLine("Массив: ");
PrintArray(NewArray);
double [] AverageArray = AverageRows(NewArray);
Console.WriteLine("Среднее арифметическое строк массива: ");
for (int i = 0; i < NewArray.GetLength(0); i++)
        {
            Console.Write($"{AverageArray[i]}  ");
        }

