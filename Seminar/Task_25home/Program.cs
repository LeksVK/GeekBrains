// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень возведения:");
int step = Convert.ToInt32(Console.ReadLine());

int StepNum(int num) {
    int i = 1;
    int newNum = 1;

    while (i <= step) {
        newNum = newNum * num;
        i++;
    }
    return newNum;
}

int result = StepNum(num);


Console.WriteLine(result);