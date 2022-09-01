Console.Clear();


Console.Write("введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());   

Console.Write("введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());   

Console.Write("введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());   

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

