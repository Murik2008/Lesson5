//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] FillMatrix(int columns, int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rand= new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
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
int[,] list = FillMatrix(4,5,0,5);
PrintMatrix(list);
int GetSum(int[,] array, int num)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = sum + array[num,i];
    }
    return sum;
}
int LessSumNumber(int[,] array)
{
    int num = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        if (GetSum(array,i)<GetSum(array,i+1)) num=i+1;
    }
    return num;
}
int lessColumnSum = LessSumNumber(list);
Console.WriteLine();
Console.WriteLine(lessColumnSum);