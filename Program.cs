using System.Reflection.Emit;

namespace CinemaBookingSystem;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Cinema Booking System");
    Label1:
        Console.WriteLine("Ticket Price :" + "\n" + "1. Recliner - 200" + "\n" + "2. Balcony - 150" + "\n" + "3. Basic - 100" + "\n" + "Please enter 1,2,3 for respective seat type");
        int ticketType = int.Parse(Console.ReadLine());
        int ticketPrice;
        switch (ticketType)
        {
            case 1:
                ticketPrice = 200;
                break;
            case 2:
                ticketPrice = 150;
                break;
            case 3:
                ticketPrice = 100;
                break;
            default:
                Console.WriteLine("Wrong ticket type selected");
                goto Label1;
        }
        Console.WriteLine("Enter No. of ticket do you want to book..?");
        int ticketCount = int.Parse(Console.ReadLine());
        int totalPrice = ticketPrice * ticketCount;
        Console.WriteLine("Total Price : {0}", totalPrice);
        Console.WriteLine("Please enter 1 to confirm ticket");
        int confirmation = int.Parse(Console.ReadLine());
        if (confirmation == 1)
        {
            Console.WriteLine("Ticket Confirmed..!");
        }
        else
        {
            Console.WriteLine("Ticket Cancelled...!");
        }
        Console.WriteLine("Please 1 to continue");
        int continuation = int.Parse(Console.ReadLine());
        if (continuation == 1)
        {
            goto Label1;
        }
    }
}






