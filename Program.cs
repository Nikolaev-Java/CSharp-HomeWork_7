/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
int[,] arr = FillMultiDimArray();
PrintMultiDimArray(arr);
int position;
Console.WriteLine("Введите позицию элемента в массиве");
while (!int.TryParse(Console.ReadLine(), out position))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
int rowPosition = position / 10 - 1;
int columnPosition = position % 10 - 1;
if (rowPosition > arr.GetLongLength(0) || columnPosition > arr.GetLength(1))
{
	Console.WriteLine("такого числа в массиве нет");
}
else
{
	Console.WriteLine($"{arr[rowPosition, columnPosition]}");
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
