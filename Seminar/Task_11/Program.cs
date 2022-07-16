

int n = new Random().Next(100,999);

Console.WriteLine(n); //564 564/100 = 5,64  564/10 = 56,4

int changeNum (int num) { // метод может находиться в любом месте, в том числе ниже вызова
    int firstDigit = num / 100;
//    int secondDigit = (num - firstDigit * 100) / 10;
    int thirdDigit = num % 10;

    int newNum = firstDigit * 10 + thirdDigit;
    return newNum;
}

int newDigit = changeNum(n);
Console.WriteLine(newDigit);
