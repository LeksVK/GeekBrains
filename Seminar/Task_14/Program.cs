Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int DelDigit (int num) {
    int firstRule = 0;
    int secondRule = 0;

    if(n % 7 > 0) {
        firstRule = 1;
    }

    if(n % 23 > 0) {
        secondRule = 1;
    }

    if(firstRule == 0 && secondRule == 0) {
    return 1;
    } else return 0;

}

int result = DelDigit(n);

if(result == 1) {
    Console.WriteLine("Число кратно 7 и 23 одновременно");
} else 
    Console.WriteLine("Число не кратно 7 и 23");
