int[,] arr = new int[5,5];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i + j ==4)
        {
            arr[i,j] = 1;
        }
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i == j)
        {
            arr[i,j] = 1;
        }
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i == 4)
        {
            arr[i,j] = 1;
        }
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}

