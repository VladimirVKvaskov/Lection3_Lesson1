Console.Clear();

Console.Write("Введите число: ");
int abc = Convert.ToInt32(Console.ReadLine());
string abcString = Convert.ToString(abc);

    if (abcString.Length > 2)
        {
      Console.WriteLine("Третья цифра = " + abcString[2]);
        }
    else 
        {
      Console.WriteLine("третьей цифры нет");
        }