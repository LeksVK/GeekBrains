// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

void stepN(int n) {

    int newN = 0;
    int i = 1;

    Console.Write($"{n} -> ");

    while(i <= n) {
        newN = i*i*i;
        //Console.WriteLine($"{i} -- {newN}");

        if(i==n) {
            Console.Write($"{newN}");
            Console.WriteLine("");
        } else {
            Console.Write($"{newN}, ");
        }

        i++;
    }
}

stepN(n);