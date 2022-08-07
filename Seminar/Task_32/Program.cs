int[] array = {-4, -8, 8, 2};

int[] ChangeArray (int[] list) {
    int n = -1;

    for (int i = 0; i < list.Length; i++)
    {
        list[i] = list[i] * n;
    }

    return list;
}

void PrintArray(int[] array) {
    int i = 0 ;
    while (i < array.Length) {
        Console.Write(array[i] + " ");
        i++;
    }
}

int[] result = ChangeArray(array);

PrintArray(result);
Console.WriteLine();