// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// [7, 6, 1]
// [1, 8, 1]
// [3, 6, 2]

int m = 3; //кол-во строк 
int n = 3; // кол-во столбцов

//int[,] array = new int[m, n];

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

int[,] DelElInMatrix(int[,] array) {   
        
        int min = array[0,0];
        int m = 0;
        int n = 0;

        for (int i = 0; i < array.GetLength(0); i++) //строки
        {
            for (int j = 0; j < array.GetLength(1); j++) //столбцы
            {
                if (array[i,j] < min) {
                    min = array[i,j];
                    m = i;
                    n = j;
                }
            }
        }

        Console.WriteLine(min);
        Console.WriteLine(m);
        Console.WriteLine(n);

        int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

        int str = 0;
        int col = 0;

    
        for (int i = 0; i < newArray.GetLength(0); i++) //строки
        {
            for (int j = 0; j < newArray.GetLength(1); j++) //столбцы
            {
                if (i == n) {
                    
                } else if (j == m) {
                    newArray[i,j] = array[i, j+1];
                    
//                    newArray[str,col] = array[i,j]; 
//                    col++;
                } else {
                    newArray[i,j] = array[i, j];
                }
            }

//            str++;
        }
    

    return newArray;
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

void PrintArray (int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length -1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix);
Console.WriteLine();

int[,] newMatrix = DelElInMatrix(matrix);
PrintMatrix(newMatrix);
Console.WriteLine();