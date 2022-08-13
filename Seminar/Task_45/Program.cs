
int[] array = {};

int[] CopyArray (int[] array) {
    int[] doubleArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++) {
        doubleArray[i] = array[i];
    }

    return doubleArray;
    
}

int[] newArray = CopyArray(array);