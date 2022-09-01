Console.Clear();

Console.Write("введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());   

Console.Write("введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());   

int max = a;
int min = b;

if(a > b) max = a;
if(b > a) max = b;

Console.Write("max = ");
Console.WriteLine(max);

