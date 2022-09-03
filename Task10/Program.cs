Console.Clear();
  
Console.Write("Введите трехзначное число: ");
int threeDigit = Convert.ToInt32(Console.ReadLine());
string digitNumber = Convert.ToString(threeDigit);
Console.WriteLine(digitNumber[1]);