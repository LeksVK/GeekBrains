// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

if( 100 <= n) {
    int newDigit = changeNum(n);
    Console.WriteLine($"{n} -> {newDigit}");

} else Console.WriteLine($"{n} -> третьей цифры нет");

int changeNum (int num) { 
    int firstDigit = num%1000; 
    int secondDigit = firstDigit/100;
    return secondDigit;
}

