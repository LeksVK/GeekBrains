
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

int MultiNum(int num) {
    int count = 1;

    for(int i = 1; i <= num; i++) {
        count = count * i;
    }
    return count;
}

int result = MultiNum(n);

 Console.WriteLine($"Произведение чисел от 1 до {n} = {result}");