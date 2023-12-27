string month = Console.ReadLine();
int numberDays  = int.Parse(Console.ReadLine());

double studioPrice = 0.00;
double apartmentPrice = 0.00;



switch (month)
{
    case "May":
    case "October":
        studioPrice = 50.00;
        apartmentPrice = 65.00;
        if (numberDays > 7 && numberDays <14)
        {

            studioPrice *= 0.95;
        }
        else if (numberDays >= 14)
        {
            studioPrice *= 0.70;      
        }
        break;

    case "June":
    case "September":
        studioPrice = 75.20;
        apartmentPrice = 68.70;
        if (numberDays > 14)
        {
            studioPrice *= 0.80;
        }
        break;
              
    case "July":
    case "August":
        studioPrice = 76.00;
        apartmentPrice = 77.00;
        break;

}
if (numberDays > 14)
{
    apartmentPrice *= 0.90;
}
double totalPriceApartment = apartmentPrice * numberDays;
double totalPriceStudio = studioPrice * numberDays;

Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");








//switch (season)
//{
//    case "Spring": boatPrice = 3000; break;
//    case "Summer":
//    case "Autumn":
//        boatPrice = 4200; break;
//    case "Winter": boatPrice = 2600; break;
//}

//if (fishers <= 6)
//{
//    boatPrice *= 0.9;
//}
//else if (fishers <= 11)
//{
//    boatPrice *= 0.85;
//}
//else
//{
//    boatPrice *= 0.75;
//}

//if (fishers % 2 == 0 && season != "Autumn")
//{
//    boatPrice *= 0.95;
//}

//if (groupBudget >= boatPrice)
//{
//    Console.WriteLine($"Yes! You have {(groupBudget - boatPrice):F2} leva left.");
//}