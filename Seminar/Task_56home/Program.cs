// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 4; //кол-во строк 
int n = 4; // кол-во столбцов

int[,] array = new int[m, n];

int[,] GetMatrix (int m, int n) {

    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1);j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

int ChangeMatrix(int[,] array) {
    int i = 0;
    int num = i;
    int sumNum = 0;
    int minSum = 0;

        for ( i = 0 ; i < array.GetLength(0); i++) //строки
        {   
            for (int j = 0; j < array.GetLength(1); j++) //столбцы
            {
               sumNum = sumNum + array[i,j];
               
               if(i == 0 && j == array.GetLength(1)-1) {
                minSum = sumNum;
               }
               
            }

            if (sumNum < minSum) {
                minSum=sumNum;
                num = i;
            }   
            // Console.WriteLine("sum " + sumNum);
            //  Console.WriteLine("sum " + minSum);
            //  Console.WriteLine("str " + i);
            sumNum = 0;
        }

    return num;
    
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
int str = ChangeMatrix(matrix);
//PrintMatrix(newMatrix);

Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (str+1) +" строка");