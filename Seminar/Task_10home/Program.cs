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
    // 5438965  -3    5438965/ 100 54389 54389/100 543
    while (num >= 1000) {
        num = num / 100;
    }

    int findN = num % 10;
    return findN;
}

