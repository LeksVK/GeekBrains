// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int WeekDay(int num) {
    if(num == 6 || num == 7) {
        return 1;
    } else return 0;
}

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if( 0 < n && n <= 7) {

    int result = WeekDay(n);
    
    if(result>0) {
        Console.WriteLine($"{n} -> да");
    } else Console.WriteLine($"{n} -> нет");

} else Console.WriteLine($"Число {n} не является днем недели, попробуйте еще раз.");

