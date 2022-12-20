int Max(int arg1, int arg2, int arg3)
{
    int resault = arg1;
    if(arg2 > resault) resault = arg2;
    if(arg3 > resault) resault = arg3;
    return resault;
}

int a1 = 23;
int b1 = 12;
int c1 = 56;
int a2 = 679;
int b2 = 3;
int c2 = 44;
int a3 = 54536;
int b3 = 40;
int c3 = 9;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);