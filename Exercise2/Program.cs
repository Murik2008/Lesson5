//Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] FillMatrix(int columns, int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rand= new Random();
    for (int i = 0; i < columns; i++)
    {
        for (int l = 0; l < rows; l++)
        {
            array[i,l] = rand.Next(minValue, maxValue+1);
        }
    } 
    return array;
} 
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            Console.Write(array[i, l] + " ");
        }
        Console.WriteLine();
    }
}
int[,] list = FillMatrix(4,4,0,10);
PrintMatrix(list);
void ChangeRows(int[,] array)
{
    int num = 0;
    for (int i = 0; i < array.GetLength(0)/2; i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
         num = array[i,l];
         array[i,l] = array[array.GetLength(0)-1-i,l];
         array[array.GetLength(0)-1-i,l] = num;
        }
    }
}
ChangeRows(list);
Console.WriteLine();
PrintMatrix(list);