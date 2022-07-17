Console.WriteLine("Введите четверть:");
int a = Convert.ToInt32(Console.ReadLine());

string Quarter(int q) {

    if(q==1) {    return "x > 0, y > 0"; } 
    if(q==2) {    return "x < 0, y > 0"; }
    if(q==3) {    return "x < 0, y < 0"; }
    if(q==4) {    return "x > 0, y < 0"; }
    else { return "Введены некорректные координаты";}

}

string message = Quarter(a);

Console.WriteLine(message);