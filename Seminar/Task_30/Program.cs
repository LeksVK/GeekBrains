// Задача 30: Напишите программу, которая задаёт массив из 8 элементов, заполняет его
// псевдослучайными числами 0, 1 и выводит их на экран.
// 0, 1, 0, 0, 1, 0, 1, 0 -> [0, 1, 0, 0, 1, 0, 1, 0]

int[] array = new int[8];

int[] FullArray(int[] array) {

    int n = array.Length;
    int[] newArray = array;
    int i =0;

    while (i <= n-1) {
        int x = new Random().Next(0,2);
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





// int[] array = new int[8];


// int[] FullArray(int[] arr) {

//     int[] array = arr;

//     for(int i=0; i<= array.Length ; i++) {
//         int x = new Random().Next(0,2);
//         array[i] = x;
//     }
//     return array;
// }

// void PrintArray(int[] array) {
//     int i = 0;
//     while (i <= array.Length ) {
//         Console.Write(array[i] + " ");
//         i++;
//     }
// }


// FullArray(array);
// PrintArray(array);

