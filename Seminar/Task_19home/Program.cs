// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if( 10000 <= n && n <= 99999) {
    int newDigit = changeNum(n);
    string mes = checkPoly(newDigit);
     Console.WriteLine($"{n} -> {mes}");

} else Console.WriteLine("Вы ввели не подходящее число, попробуйте еще раз.");



int changeNum (int num) {
    // 14212 | 1421 2 20000 | 142 1 1000....|
    int x = 10000;
    int newDigit = 0;

    while (num > 0) {
        int ost = num % 10;
        int newN = ost * x;
        newDigit = newN + newDigit;
        //Console.WriteLine(newDigit);

        x = x/10;
        num = num/10;
    }

    return newDigit;
}

string checkPoly(int x) {
    if(x == n) {
        return "да";
    } else 
        return "нет";
}