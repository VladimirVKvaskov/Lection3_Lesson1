Console.Clear();

Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;

    while(count < a+1)

    {   
        if (count % 2 == 0)
        Console.WriteLine(count);
        count = count + 1;
    }