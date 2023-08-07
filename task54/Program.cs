// : Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] Create2DMassiv(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

int  GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Print2DMassiv(int [,] massiv)
{
 for(int i = 0; i < massiv.GetLength(0); i++)
    {
        for(int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] OrderMassivMaxToMin(int [,] massiv) 
{
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < massiv.GetLength(1) - 1; z++)
        {
            if (massiv[i, z] < massiv[i, z + 1]) 
            {
                int temp = 0;
                temp = massiv[i, z];
                massiv[i, z] = massiv[i, z + 1];
                massiv[i, z + 1] = temp;
            }
        }
    }
    
}
return massiv;
}

int rows = GetInput("Введите количество строк массива: ");
int columns = GetInput("Введите количество столбцов массива: ");
int [,] massiv = Create2DMassiv(rows,columns);
Print2DMassiv(massiv);
OrderMassivMaxToMin(massiv);
Console.WriteLine();
Print2DMassiv(massiv);