Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

void stepN(int n) {

    int newN = 0;
    int i = 1;

    while(i <= n) {
        newN = i*i;
        Console.WriteLine($"{i} -- {newN}");
        i++;
    }
}

stepN(n);