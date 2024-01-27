string movieType = Console.ReadLine();
int rowsCount = int.Parse(Console.ReadLine());
int seatsCount = int.Parse(Console.ReadLine());

double totalAmount = 0.00;
double ticketPrice = 0;


if (movieType == "Normal")
{
    ticketPrice = 7.50;
 

}
else if (movieType == "Premiere")
{
    ticketPrice = 12.00;


}
else if (movieType == "Discount")
{
    ticketPrice = 5.00;

}

totalAmount = rowsCount * seatsCount * ticketPrice;
Console.WriteLine($"{totalAmount:F2}");