using System;

// 1. Kalkulyator:
int a,b;
Console.Write("Birinchi sonni kiriting=> ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Quyidagi arifmetik amallardan birini kiriting: +,-,*,/ => ");
string arifmetikAmal=Convert.ToString(Console.ReadLine());
Console.Write("ikkinchi sonni kiriting=> ");
b=Convert.ToInt32(Console.ReadLine());
switch (arifmetikAmal)
{
    case "+": 
        Console.WriteLine(a+b);
    break;
    case "-": 
        Console.WriteLine(a-b);
    break;
    case "*": 
        Console.WriteLine(a*b);
    break;
    case "/": 
        Console.WriteLine(a/b);
    break;
    default:
        Console.WriteLine("Siz noto'g'ri arifmetik amalni kiritdingiz. Iltimos aytatdan urinib ko'ring...");
    break;
}

// 2. Raqamlar qatorining yig‘indisini hisoblash:
int n,S=0;
Console.Write("Musbat butun sonn kiriting => ");
n=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n; i++)
{
    S=S+i;
}
Console.WriteLine($"{n} gacha bo'lgan sonlarning yig'indisi {S} ga teng... ");

// 3.  Paritet tekshiruvi:
int m;
Console.Write("Butun sonn kiriting => ");
m = Convert.ToInt32(Console.ReadLine());
if(m%2==0)
{
    Console.WriteLine("Juft");
}
else Console.WriteLine("Toq");