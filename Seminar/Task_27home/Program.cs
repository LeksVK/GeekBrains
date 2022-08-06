// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());


if (num > 0) {
    int result = SumNum(num);
    Console.WriteLine(result);
} else Console.WriteLine("Введите другое число:");

int SumNum(int num) {
    int newNum = 0;    
    int sum = 0;
    
    while (num > 0) {
    newNum = num%10;
    sum = sum + newNum;
    num = num/10;
    }

    return sum;
}