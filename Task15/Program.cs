Console.Clear();

Console.Write("Введите номер дня недели от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

DayWeek(dayNumber);

void DayWeek (int dayNumber) 
    {
        if (dayNumber == 6 || dayNumber == 7) {
        Console.WriteLine("выходной");
            }
                else if (dayNumber < 1 || dayNumber > 7) {
                 Console.WriteLine("в неделе от 1 до 7 дней");
             }
                 else Console.WriteLine("будний");
    }

