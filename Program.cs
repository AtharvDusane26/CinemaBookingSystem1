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
                Console.WriteLine("Please enter 1, 2, or 3 for respective seat type: ");
            default:
                Console.WriteLine("invalid Seat Type,Please Select again");

                goto Label1;

                Console.WriteLine("Enter No. of Ticket You Want To Select...?");
                if (ticketType == 1)
                {

                    Console.WriteLine("You will Get 20% Disscount On Meal Price");
                    int TicketCount = int.Parse(Console.ReadLine());
                    int Disscount = int.Parse(Console.ReadLine());
                    int TotalPriceOfTicket = (TicketCount * ticketPrice );
                    Console.WriteLine("Total Price Of Ticket: {0}", TotalPriceOfTicket);

                }

                else if (ticketType == 2)
                {

                    Console.WriteLine("You will Get 10% Discount On Meal Price");
                    int Disscount = int.Parse(Console.ReadLine());
                    int TicketCount = int.Parse(Console.ReadLine());
                    int TotalTicketPrise = (TicketCount * ticketPrice );
                    Console.WriteLine("Total Price Of Ticket: {0}", TotalTicketPrise);
                }

                // Console.WriteLine("Enter No. of Ticket You Want To Select...?");
                // int TicketCount = int.Parse(Console.ReadLine());
                //  int TotalPriceOfTicket = (TicketCount * ticketPrice);
                //Console.WriteLine("Total Price Of Ticket: {0}", TotalPriceOfTicket);

                Console.WriteLine("Meal Price :" + "\n" + "1. Cold drink and French Frise - 400" + "\n" + "2. Cold Drink and Popcorn - 350" + "\n" + "3.Cold Drink and Waffles - 500" + "\n" + "Please enter 1,2,3 for respective Meal type");
                int MealType = int.Parse(Console.ReadLine());
                int MealPrice;
                switch (MealType)
                {
                    case 1:
                        MealPrice = 400;
                        break;
                    case 2:
                        MealPrice = 350;
                        break;
                    case 3:

                        MealPrice = 500;
                        break;
                        Console.WriteLine("Please enter 1, 2, 3 for respective Meal Type: ");
                    default:
                        MealPrice = 0;
                        break;

                }


                Console.WriteLine("Enter No. of Combo you want select...?");
                int MealCount = int.Parse(Console.ReadLine());
                int TotalPriceOfMeal = (MealCount * MealPrice);
                Console.WriteLine("Total Price Of Meal : {0}", TotalPriceOfMeal);



                // int TotalCost = TotalPriceOfTicket + TotalPriceOfMeal;
                //Console.WriteLine("Your Total Cost Is : {0}",TotalCost);


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
}




