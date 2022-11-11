// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] GetInt3dArray(int a, int b, int c)
{
    int[,,] array3D = new int[a, b, c];
    int[] temp = new int[a * b * c];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100); 
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j]) 
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0; 
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
    return array3D;
}

void Print3dArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива (X x Y x Z): ");
Console.WriteLine();
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine()!);

if (x * y * z > 90) Console.WriteLine("Cлишком большой массив");
else
{
    int[,,] array = GetInt3dArray(x, y, z);
    Print3dArray(array);
}
