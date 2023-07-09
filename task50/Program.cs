// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> на этой позиции числа в массиве нет

int rows = Prompt("Введите коллиичество строк");
int columns = Prompt("Введите количесвто столбцов");


int[,] dvumerMassive = GetArray(rows,columns);
PrintArray(dvumerMassive);
FindElementArr( dvumerMassive);

void FindElementArr(int[,] Array)
{
Console.WriteLine("Введите координаты");
 int R = int.Parse(Console.ReadLine());
 int C = int.Parse(Console.ReadLine());
 if(R < Array.GetLength(0) && C< Array.GetLength(1))
        {
            Console.Write(Array[R, C]);
        }
        else
        {
            Console.WriteLine("Элемента с данными координатами не существет");
        }
}



int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);

        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) - длина столбцов
        {
            Console.Write(arr[i, j] + " | ");

        }
        Console.WriteLine();
    }
}
