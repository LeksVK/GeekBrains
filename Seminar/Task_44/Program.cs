Console.WriteLine("Введите кол-во чисел Фибоначи:");
int num = Convert.ToInt32(Console.ReadLine());

void PrintFibonachi(int num) {
    int f = 0;
    int b = 1;
    int c = 0;

    for (int i = 0; i < num; i++){
        Console.Write(f+" ");
        c = f+b; // 1 2 3 7 
        f = b;   // 1 1 2 5
        b = c;   // 1 2 5 7
    }

    Console.WriteLine();
}

PrintFibonachi(num);