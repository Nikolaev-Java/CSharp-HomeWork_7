/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int m = 3;
int n = 4;
double[,] arrRealNumber = FillRandomArrayReal(m, n);

PrintToConsoleMultiDimArrayReal(arrRealNumber, m, n);

double[,] FillRandomArrayReal(int _m, int _n)
{
	double[,] array = new double[_m, _n];
	for (int i = 0; i < _m; i++)
	{
		for (int j = 0; j < _n; j++)
		{
			array[i, j] = Math.Round((new Random().NextDouble() * 100), 2);
		}
	}

	return array;
}
void PrintToConsoleMultiDimArrayReal(double[,] array, int _m, int _n)
{
	for (int i = 0; i < _m; i++)
	{
		for (int j = 0; j < _n; j++)
		{
			Console.Write($"{array[i, j]} | ");
		}
		Console.WriteLine("");
	}
}
