
// Преобразовывает десятичное число в двоичное

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());


void ConvertNumToBinary(int num) {

    // string newNum = string.Empty;

    // while (num > 0) {
    //     int res +=num%2;
    //     num1 /= 2;

    //}

    string binary = string.Empty;
    while (num >= 1) {
        binary+= num%2;
        num /=2;
    }
    var item = binary.Reverse();
    binary = "";
    foreach(var i in item) {
        binary +=i.ToString();
    }

    Console.WriteLine(binary);
    
    // for (int i = 0; num > 1; i++)
    // {
    //      newNum += num%2;
    //      if (num%2 != 0) {
    //         newNum += "1";
    //         } 

    //      num /= 2; // num = num/2
    //      newNum += "0";
    // }

        // var item = newNum.Reverse();
        // newNum = "";
        // foreach(var i in item) {
        //     newNum +=i.ToString();
        // }

   //Console.WriteLine(newNum);


//    new int[i] 

}

ConvertNumToBinary(num);