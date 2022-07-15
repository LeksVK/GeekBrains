
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int ost = x%2;

if(ost > 0) {
    Console.WriteLine("Число нечетное");
} else {
    Console.WriteLine("Число четное");
}