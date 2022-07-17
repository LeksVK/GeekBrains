// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

if( 100 <= n && n < 1000) {
    int newDigit = changeNum(n);
    Console.WriteLine($"{n} -> {newDigit}");

} else Console.WriteLine("Вы ввели не подходящее число, попробуйте еще раз.");

int changeNum (int num) { 
    int firstDigit = num / 100;
    int secondDigit = (num - firstDigit * 100) / 10;
    return secondDigit;
}

