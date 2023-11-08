int studentTiketsCount = 0;
int standardTicketCount = 0;   
int kidTicketCount = 0;

string moviename;

while ((moviename = Console.ReadLine()) != "Finish")
{ 
  int freeSeats = int.Parse(Console.ReadLine());

    int takenSeats = 0;
    string ticketsType;

    while(takenSeats < freeSeats && (ticketsType = Console.ReadLine()) != "End")
    {
        takenSeats++;

        switch(ticketsType) 
        {
            case "student":
                studentTiketsCount++;
                break;
            case "standard":
             standardTicketCount++;
                break;
            case "kid":
                kidTicketCount++; 
                break;
             default:
                break;
        }
    }
    double projectionPersentage = ((double)takenSeats / freeSeats) * 100;

    Console.WriteLine($"{moviename} - {projectionPersentage:F2}% full.");
}
int totalTicketsCount = studentTiketsCount + standardTicketCount + kidTicketCount;
double studentPersentage = ((double)studentTiketsCount / totalTicketsCount) * 100;
double standartPersentage = ((double)standardTicketCount / totalTicketsCount) * 100;
double kidPersentage = ((double)kidTicketCount / totalTicketsCount) * 100;

Console.WriteLine($"Total tickets: {totalTicketsCount}");
Console.WriteLine($"{studentPersentage:F2}% student tickets.");
Console.WriteLine($"{standartPersentage:F2}% standard tickets.");
Console.WriteLine($"{kidPersentage:F2}% kids tickets.");
