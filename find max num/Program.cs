string input = Console.ReadLine();
int maxNumbre = int.MinValue;
while (input != "Stop")
{ 
  int num = int.Parse(input);
    if(num > maxNumbre)
        maxNumbre = num;
    input = Console.ReadLine(); 
}
Console.WriteLine(maxNumbre);