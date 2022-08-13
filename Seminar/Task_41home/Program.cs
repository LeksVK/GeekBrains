// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

FullArrayUser(array);
int result = ToCountMore(array);
Console.WriteLine($"Введено {result} чисел больше 0");

void FullArrayUser (int[] array) {
    int size = array.Length;
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Все введено. Спасибо =)");
   
}

int ToCountMore(int[] array) {
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) {
            count++;
        } 
    }

    return count;
}