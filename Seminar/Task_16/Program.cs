Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int i;

int CheckQuadro(int num1, int num2) {
    if (num1 > num2) {
        num2 = num2*num2;
    } else num1 = num1*num1;

    if(num1 == num2) {
        return i=1;
    } else return i = 0;
}

int result = CheckQuadro(a, b);

if(result>0) {
    Console.WriteLine("да");
} else Console.WriteLine("нет");

