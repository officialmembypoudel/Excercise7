namespace Excercise7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running Program");

        Calendar calendar = new Calendar();

        calendar.PrintWeekdays();

        Console.ReadKey();
    }
}

