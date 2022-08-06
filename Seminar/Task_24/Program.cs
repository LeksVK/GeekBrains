Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;


int GetSum(int atr) {
    for (int i = 1; i <= atr; i++) {
        sum = sum + i;
    }
    return sum;
}

int result = GetSum(a);

Console.WriteLine($"{a} -> {result}");