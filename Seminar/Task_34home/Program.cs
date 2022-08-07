// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];

int[] FullArray(int[] array) {

    int n = array.Length;
    int[] newArray = array;
    int i =0;

    Random rnd = new Random();

    while (i <= n-1) {
        int x = rnd.Next(100,1000);
        newArray[i] = x;
        i++;
    }

    return newArray;
}

int FindCountNum(int[] array) {
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) {
            res+=1;
        } else res+=0;
    }

    return res;
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
int result = FindCountNum(array);
Console.WriteLine();
Console.WriteLine($"В массиве {result} четных числа");