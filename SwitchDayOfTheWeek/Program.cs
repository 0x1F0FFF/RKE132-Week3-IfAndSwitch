int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); // 0 - 6
//int weekDay = 7; // lihtsalt test

switch (weekDay) // kontrollitav väärtus
{
    case 0: // case 0 on samaväärne if (weekDay == 0)
        Console.WriteLine("It's Sunday!");
        break;
    case 1:
        Console.WriteLine("It's Monday, never lucky...");
        break;
    case 2:
        Console.WriteLine("It's Tuesday.");
        break;
    case 3:
        Console.WriteLine("It's Wednesday.");
        break;
    case 4:
        Console.WriteLine("It's Thusrday");
        break;
    case 5:
        Console.WriteLine("It's Friday.");
        break;
    case 6:
        Console.WriteLine("It's Saturday.");
        break;
    default:
        Console.WriteLine("Oops... Look's like your calendar is broken.");
        break;
        
}

Console.WriteLine("Have a nice day!");
