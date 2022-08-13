
// Преобразовывает десятичное число в двоичное

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());


void ConvertNumToBinary(int num) {
    if( num == 0) return;
    ConvertNumToBinary(num/2);
    Console.Write(num%2);
}

ConvertNumToBinary(num);
Console.WriteLine();