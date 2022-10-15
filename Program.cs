/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int[,] arr = FillMultiDimArray();
PrintMultiDimArray(arr);
Console.Write("Среднее арифметическое для каждого столбца: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
	double average = 0;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		average += arr[i, j];
	}
	average = Math.Round(average / arr.GetLength(0), 2);
	Console.Write($"{average}; ");
}





int[,] FillMultiDimArray(int _m = 3, int _n = 4)
{
	int[,] array = new int[_m, _n];
	for (int i = 0; i < _m; i++)
	{
		for (int j = 0; j < _n; j++)
		{
			array[i, j] = new Random().Next(10);
		}
	}
	return array;
}
void PrintMultiDimArray(int[,] array)
{
	for (int i = 0; i < array.GetLongLength(0); i++)
	{
		for (int j = 0; j < array.GetLongLength(1); j++)
		{
			Console.Write($"{array[i, j]} | ");
		}
		Console.WriteLine("");
	}
}
