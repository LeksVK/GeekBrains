// Задать двумерный массив. Напишиите программу которая меняет местами первую 
// и последнюю строку массива.

int m = 3; //кол-во строк 
int n = 4; // кол-во столбцов



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

    int i = 0; 
    int j = 0;

    while (j < array.GetLength(1))
    {

    int num = array[i,j];
    array[i,j] = array[m-1, j];
    array[m-1, j] = num;
    num = 0 ;
    j++; 
    
    }
    
    return array;
    
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