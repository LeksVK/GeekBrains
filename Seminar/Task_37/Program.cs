int[] array = new int[5];


int[] FullArray(int[] array) {

    int n = array.Length;
    int[] newArray = array;
    int i =0;

    while (i <= n-1) {
        int x = new Random().Next(0, 100);
        newArray[i] = x;
        i++;
    }

    return newArray;
}

int[] DigitArray(int[] array) {

    int size = array.Length;    
    int n = size %2; // 5
    int newSize = size /2;

    if(n>0) {
        newSize = newSize + 1;
    } 
    
    int[] list = new int[newSize];

    if(n>0) {
        newSize = newSize -1;
        list[newSize] = array[newSize];
    } 

    for (int i = 0; i < newSize; i++)
    {   
        int j = size - i -1;   
        list[i] = array[i] * array[j];
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

FullArray(array);
PrintArray(array);
Console.WriteLine();

int[] result = DigitArray(array);
PrintArray(result);
Console.WriteLine();
