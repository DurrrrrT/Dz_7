//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
FillArray();
ArithmeticalMean();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(4, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ");
}

void ArithmeticalMean()
{
    for (int j = 0; j < columns; j++)
    {
        double mean = 0;
        for (int i = 0; i < rows; i++)
        {
            mean += array[i, j];
        }
        Console.WriteLine(mean / rows );
    }
    Console.WriteLine();
}