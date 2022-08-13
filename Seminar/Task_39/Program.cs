int[] array = new int[4];

int[] FullArrayRandom(int[] array) {

    int n = array.Length;
    int[] newArray = array;
    int i =0;

    Random rnd = new Random();

    while (i <= n-1) {
        int x = rnd.Next(0,100);
        newArray[i] = x;
        i++;
    }

    return newArray;
}

// int[] ToReverseArray(int[] array) { //решение с созданием нового массива, занимает больше данных 
//     int size = array.Length;
//     int[] newArray = new int[size];
//     int j = 0;

//     for (int i=size-1; i >=0; i-- ) {
//         newArray[j] = array[i];
//         j++;
//     }

//     return newArray;
// }

void ToReverseArray(int[] array) { // решение с изменением самого массива
    int size = array.Length;
    int obj;
    int j = 0;

    for (int i=size-1; i >=0; i-- ) {
        obj = array[i];
        array[i] = array[j];
        array[j]= obj;
        j++;
    }

}


void PrintArray(int[] array) {
    int i = 0 ;
    while (i < array.Length) {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine("");
}

FullArrayRandom(array);
//int[] newArray = ToReverseArray(array); // для варианта 1
ToReverseArray(array);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("");
Console.WriteLine("Новый массив: ");
//PrintArray(newArray); // для варианта 1
PrintArray(array);
