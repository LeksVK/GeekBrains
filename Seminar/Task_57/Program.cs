// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] FindNumInMatrix(int[,] array) // 1й вариант решения, через одномерный массив, без сортировки
{
    int[] result = new int[10]; //создаем новый одномерный массив, потом перебираем матрицу и при нахождение элемента прибавляем единицу к каждой позиции в матрице

        for (int i = 0; i < array.GetLength(0); i++) //строки
        {
            for (int j = 0; j < array.GetLength(1); j++) //столбцы
            {
                result[array[i,j]]++;
            }
        }

    return result;
}

int[] SortMatrix(int[,] array) // 2й вариант решения, метод для сортировки массива
{

    int[] result = new int[array.Length]; 
    int n = 0;

        for (int i = 0; i < array.GetLength(0); i++) //строки
        {
            for (int j = 0; j < array.GetLength(1); j++) //столбцы
            {
                result[n] = array[i,j];
                n++;
            }
        }

    Array.Sort(result);
    return result;
}

void CountNumInMatrix(int[] array) // 2й вариант решения, метод для подсчета отсортированных элементов
{

    int num = array[0];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) { 
            count++;
        } else {

            Console.WriteLine($"Число {num} встречается --> {count} раз");
            
            num = array[i];
            count = 1;
        } if (i == array.Length-1) {
             Console.WriteLine($"Число {num} встречается --> {count} раз");
        }

    }
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

//вывол для первого способа решения
// int[] newArray = FindNumInMatrix(matrix);
// PrintArray(newArray);
// Console.WriteLine();


// вывод для второго способа решения
int[] newArray = SortMatrix(matrix);
// вывод одномерного массива для проверки сортировки
// PrintArray(newArray);
Console.WriteLine();
CountNumInMatrix(newArray);