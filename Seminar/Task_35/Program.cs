int[] array = new int[123];
int min = 10;
int max = 99;

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

int FindCountNum(int[] array,int min, int max) {
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min && array[i] < max) {
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
int result = FindCountNum(array, min, max);
Console.WriteLine();
Console.WriteLine($"В массиве {result} чисел в диапазоне от {min} до {max}");