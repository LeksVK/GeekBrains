int n = new Random().Next(10,99);
Console.WriteLine(n);

// int left = n/10;
// int right = n%10;

// if(left == right) {
//     Console.WriteLine("Числа равны");
// } else if(left < right) {
//     Console.WriteLine(right);
// } else {
//     Console.WriteLine(left);
// }

int MaxDigit (int num) {

    int left = num / 10;
    int right = num % 10;

    if (left == right) {
        return 0;
    }
    if (left > right) {
        return left;
    } else return right;

} 

int max = MaxDigit(n);


if(max == 0) {
    Console.WriteLine("Числа равны");
} else

Console.WriteLine(max);