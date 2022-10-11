// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте двумерный массив. Напишите программу которая заменяет строки на столбцы. 
// В случае если это не возможно, программа должна вывести сообщение 
// для пользователя.
// 0,1 - 1,0  0,2 - 2,0 i,j = j,i j++ while j = length - 1
// 2,1 - 1,2  j = length - 1 j,i = i,j j++ while

// Решение через новый массив. To do: Решение без использования нового массива. 
// вынести проверку из метода

// 1 5 8
// 4 9 2
// 7 4 2

// 1 4 7      [94, 66, 44, 63]
// 5 9 2      [44, 51, 56, 48]
// 8 4 2      [52, 80, 19, 81]

int m = 3; //кол-во строк 
int n = 3; // кол-во столбцов

int[,] array = new int[m, n];

int[,] GetMatrix (int m, int n) {

    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1);j++)
        {
            matrix[i,j] = rnd.Next(0, 100);
        }
    }

    return matrix;
}

int[,] ChangeMatrix(int[,] array) {

    int x = array.GetLength(0);
    int y = array.GetLength(1);

//    if (x == y ) {

        int i = 0;
        int j = 0;

        while (j < y-1)
            {
            int num = array[j+1, i];
            array[j+1, i] = array[i, j+1];
            array[i, j+1] = num;
            num = 0 ;
            j++; 
            }

         int k = array.GetLength(1)-1;

        while (k > k/2)
            {
            int num = array[k, k-1];
            array[k, k-1] = array[k-1, k];
            array[k-1, k] = num;
            num = 0 ;
            k--; 
            }

     return array;

 //   } else 
 //       Console.WriteLine("Невозможно произвести изменения с матрицей заданного размера.");
       
}

void PrintMatrix(int[,] array) {

    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int j = 0; j < array.GetLength(1); j++) //столбцы
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1)-1) Console.Write(array[i,j] + ", ");
            else Console.Write(array[i,j] + "]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();
int[,] newMatrix = ChangeMatrix(matrix);
PrintMatrix(newMatrix);