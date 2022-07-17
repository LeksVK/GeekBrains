Console.WriteLine("Введите координату х:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y:");
int b = Convert.ToInt32(Console.ReadLine());

int q = 0;

string Quarter(int x, int y) {

    if(x == 0 || y == 0) {
        return "Введены некорректные координаты";
    } else if (x>0) { // +x +y 1я четверть -x +y 2я четверть -x -y  3я    +x -y 4я четверть
        if(y>0) {
            q=1;
        } else {
            q=4;
        }
    } else { // +x +y 1я четверть -x +y 2я четверть -x -y  3я    +x -y 4я четверть
        if(y>0) {
            q=2;
        } else {
            q=3;
        } 
    } 

    return $"Это {q}-я четверть";
}

string message = Quarter(a, b);

Console.WriteLine(message);