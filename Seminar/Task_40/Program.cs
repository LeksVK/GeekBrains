int[] array = new int[3];

void FullArrayUser (int[] array) {
    int size = array.Length;
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Все введено. Спасибо =)");
   
}

bool CheckTriangelIsReal(int[] array) {
    bool check = false;
    Console.WriteLine("...");
    
    if (array[0] < array[1] + array[2]) {
        if (array[1] < array[0]+ array[2]) {
            if(array[2]< array[0]+ array[1]) {
                return true;
            }
            return false;
        }
        return false;
    }
    return false;

}

void PrintResult(bool result) {
    if (result == false) {
        Console.WriteLine("Треугольник не может существовать =(");
    } else

    Console.WriteLine("Треугольник может существовать)");
}

FullArrayUser(array);
bool result = CheckTriangelIsReal(array);
PrintResult(result);

