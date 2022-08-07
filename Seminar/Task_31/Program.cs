int[] CreateRandomArray (int size, int min, int max) {
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i< arr.Length; i++) {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] GetSummArrayNum (int[] array) {
    int sumN = 0;
    int sumP = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) {
            sumN += array[i];
        } else {
            sumP += array[i];
        }
    }    
    return new int[] {sumN, sumP};
}

void PritArray (int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length -1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateRandomArray(12,-9, 9);
PritArray(array);
int[] SummArrayNum = GetSummArrayNum(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел - {SummArrayNum[1]}");
Console.WriteLine($"Сумма отрицательных чисел - {SummArrayNum[0]}");