//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
//
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]  
//["1234", "1567", "-2", "computer science"] -> ["-2"]  
//["Russia", "Denmark", "Kazan"] -> [] 


Console.WriteLine("Сколько строк вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());
int num = 3;

string[] array = new string[size];

void FullArrayUser (string[] array) {
    int size = array.Length;
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите строку:");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine("Все введено. Спасибо =)");
   
}

string[] filterArrayString (string[] array) {

    string[] newArray = new string[array.Length];
    int i = 0;
    int j = 0;
    string stroke = string.Empty;

    for ( i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num)
        {
            stroke = "";
            stroke = array[i];
            newArray[j] = stroke;
            j++;
        }       
    }

    return newArray;
 }

void PrintArray(string[] array) {
    int i = 0 ;
    Console.WriteLine($"Строки, длина которых меньше {num}:");
    Console.Write("[");
    while (i < array.Length) {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.Write("]");
    Console.WriteLine("");
}

FullArrayUser(array);
string[] newArray = filterArrayString(array);
PrintArray(newArray);