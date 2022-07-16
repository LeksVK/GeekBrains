//             0   1   2   3   4    5   6   7   8  
int[] array = {45, 17, 68, 512, 23, 43, 13, 23, 33};


int Max(int arg1, int arg2,int arg3) {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    
    ); //3й способ 

Console.WriteLine(max);