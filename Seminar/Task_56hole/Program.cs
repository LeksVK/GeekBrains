// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// создаем новый массив

// искомая строка на 1 больше итого эл-а
// в массиве получаем число = сумме всех итых эл-в при житом равном 0
// записываем число в массив

// берм вторую строку житое равно 1 получаем ссумму итых
// записываем в строку

// делаем перебор по кол-ву строк (= числу джи)

// после этого ищем максимальное число в массиве (функция)
// определяем индекс элемента = номеру строки

// выводим результат пользователю

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
    int id = 0;
            int num = i;
            int sumNum = 0;
            int maxSum = 0;

    while (id <= array.GetLength(0)-1) {
        for (int i = 0; i < array.GetLength(0); i++) //строки
        {   
            for (int j = 0; j < array.GetLength(1); j++) //столбцы
            {
                while (j != array.GetLength(1)-1) {

                    if (array[i,j] < array[i, j+1] ) {
                        int n = array[i,j];
                        array[i,j] = array[i, j+1];
                        array[i, j+1] = n;
                    }

                    j++;
                }
            }
        }
        id++;
    
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