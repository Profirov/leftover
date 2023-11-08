string input = Console.ReadLine();
int minNumber = int.MaxValue;

while (input != "Stop")
{ 
 int num = int.Parse(input);

    if (num < minNumber)
    minNumber = num;

    input = Console.ReadLine();
}
Console.WriteLine(minNumber);
    