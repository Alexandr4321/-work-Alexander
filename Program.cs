Console.Write("input your first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("input your second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
 
int min = 0 ;
int max = 0 ;

if(numberA < numberB)
{
     min = numberA;
     max = numberB;
}
else
{
     min = numberB;
     max = numberA;
}
Console.WriteLine($"Самое маленькое число : {min}");
Console.WriteLine($"Самое большое число : {max}");