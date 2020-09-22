using System;
class Lab1_04p16
{
    static void Main()
    {
        int n = 0;
        Console.Write("Your number is ");
        n = Convert.ToInt32(Console.ReadLine());
        switch(n)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thirsday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("not valid");
                break;
        }
        Console.ReadKey();
    }
}
