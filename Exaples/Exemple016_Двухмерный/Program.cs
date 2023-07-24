
// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }

void PrintArray(int[,] matr) // метод печати двухмерного массива (заполняется 0)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]} "); // выводим на консоль матрицу
        }
        Console.WriteLine(); // пустая строка
    }
}

void FillArray(int[,] matr) // заполняем наш массив рандомными числами
{
    for (int i = 0; i < matr.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            matr[i, j] = new Random().Next(1, 10); // числами от 1 до 9
        }
    }
}

int[,] matrix = new int[3, 4]; // задаем массив 3 строки и 4 столбца
PrintArray(matrix); // печатаем массив
FillArray(matrix); // получен новый массив
Console.WriteLine(); // пустая строка
PrintArray(matrix); // печатаем новый массив

