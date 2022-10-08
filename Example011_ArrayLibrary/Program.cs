void FillArray(int[] collection) { //метод заполнения массива случайными числами
    int length = collection.Length;
    int index = 0;

    while(index < length) {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col) { //метод вывода содержимого массива
    int count = col.Length;
    int position = 0;

    while(position < count) {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find) {
    int count = collection.Length;
    int i = 0;
    int position = 0; // -1 указываем, условная договоренность, что если возвращается -1 элемента нет

    while (i < count) {
        if(collection[i] == find) {
            position = i;
            // break; - если хотим прервать поиск, после первого вхождения
        }
        i++;
    }
    return position;
}


int[] array = new int[10]; // создание массива размерностью 10, по умолчанию будет заполнен 0ми

FillArray(array);
Console.WriteLine(array);
PrintArray(array);
Console.WriteLine();

int find = 4;

int pos = IndexOf(array, find);


Console.WriteLine(pos);