int Max(int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if(arg2 > resault) resault = arg2;
    if(arg3 > resault) resault = arg3;
    return resault;
}
int[] array = {23, 88812, 56, 679, 3, 44, 54536, 40, 9};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
