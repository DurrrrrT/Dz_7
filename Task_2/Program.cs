//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты.
// 0 1 2 3 4
// 4 5 8 4 6  0
// 7 6 9 8 6  1
// 6 8 8 4 4  2                //6,8,9,5
// 9 9 6 5 5  3

int rows = 4;
int columns = 5;
int[,] array = new int[rows, columns];
FillArray();
Multiplication();


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

void Multiplication()
{

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                Console.Write($"{array[i, j] *= array[i, j]} ");
            }
            else
            {
                Console.Write(array[i, j] + "  ");
            }
        }
        Console.WriteLine("");
    }
}



