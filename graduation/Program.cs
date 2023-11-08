string name = Console.ReadLine();
double sum = 0;
int grades = 1;
int filedTime = 0;


while (grades <= 12)
{ 
 double grade = double.Parse(Console.ReadLine());

    if (grade >= 4)
    {
        grades++;
        sum += grade;
        continue;
    }
    filedTime++;
    if (filedTime == 2)
    {
        Console.WriteLine($"{name} has been excluded at {grades} grade");
        break;
    }
}
if (grades > 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {sum/12:F2}");
}
