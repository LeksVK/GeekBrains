int[] array = {6, 7, 19, 345, 3};

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int FindNum (int[] list) {
    int res = 0;

    for (int i = 0; i < list.Length; i++) {
        if (list[i] == num) {
            res =1;
        } else res = 0;
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

void PrintResult(int res) {
    if(res>0) {
        Console.WriteLine("да");
    } else Console.WriteLine("нет");
}

int result = FindNum(array);

PrintArray(array);
Console.WriteLine();
PrintResult(result);
Console.WriteLine();