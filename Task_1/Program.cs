// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = 3;
int columns = 4;
double[,] array = new double[rows, columns];
FillArray();


void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.NextDouble() * 10;
        }
    }
    PrintArray();
}

void PrintArray()
{

    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < columns; j++)

         Console.Write("{0, 6}", (array[i, j]).ToString("0.00") + "|");
         Console.WriteLine("");
         
    }

}