/*Console.Write("input your first number: "); // 1 задача
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
*/

// задача 2
/*
Console.Write( "Введите первое число : ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write( "Введите первое число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write( "Введите первое число : ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(numberA < numberB)
{
    max = numberB;
}
else 
{
    max = numberA;
}
if(max < numberC)
{
    max = numberC;
}
Console.WriteLine($"Самое большое число : {max}");
*/
/*
Console.Write( "Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)

   Console.Write($"число {number} четное");

else
{
   Console.Write($"число {number} не четное");
}
*/

Console.Write( "Введите число N : ");
int numberA = Convert.ToInt32(Console.ReadLine());

int current_num = numberA;
int count = 0;

while(current_num > 0)
{
    if(current_num%2 == 0)
    {
     count = count + 1;
     Console.Write(current_num+ " ");
     current_num = current_num - 1;
    }
    else
    {
    current_num = current_num - 1;
    }
}
 Console.Write("  - четные числа числа N "); 


