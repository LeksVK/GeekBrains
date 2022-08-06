// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

int[] FullArray(int[] array) {

    int n = array.Length;
    int[] newArray = array;
    int i =0;

    while (i <= n-1) {
        int x = new Random().Next(0,100);
        newArray[i] = x;
        i++;
    }

    return newArray;
}

void PrintArray(int[] array) {
    int i = 0 ;
    while (i < array.Length) {
        Console.Write(array[i] + " ");
        i++;
    }
}

FullArray(array);
PrintArray(array);









