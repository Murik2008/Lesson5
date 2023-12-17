//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
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
int[,] list = FillMatrix(3,3,0,10);
PrintMatrix(list);
void IndexNumber(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            if (x==i && y==l) Console.WriteLine(array[x,y]);
            else if (x!=i && y!=l && y!=i && x!=l && i!=l) Console.WriteLine("Такого элемента нет");
        }
    }
}
IndexNumber(list,1,2);