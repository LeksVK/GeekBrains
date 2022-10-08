// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

int[] FullArray(int[] array) {

    int n = array.Length;
    int[] newArray = array;
    int i = 0;

    Random rnd = new Random();

    while (i <= n-1) {
        int x = rnd.Next(-100,100);
        newArray[i] = x;
        i++;
    }

    return newArray;
}

int SumElemArray(int[] array) {
    int res = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        res = res + array[i];
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
int result = SumElemArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {result} ");