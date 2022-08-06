Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
// второй способ через умножение на 10

int CountNum(int a) {
    int res = 0;
    
    for (int i=1; a > 0; i++) {
        a = a/10;
        res = i;
    }

    return res;
}

int result = CountNum(a);

Console.WriteLine(result);
