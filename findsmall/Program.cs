// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a Value:\t");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a Value:\t");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a Value:\t");
int num3 = int.Parse(Console.ReadLine());
int min = 0;
if(num1 < num2 && num1 < num3)
{
min = num1;
}
else if(num2 < num3 && num2 < num1)
{
min = num2;
}
else
{
min = num3;
}
Console.WriteLine($"Smallest Value is ----- {min}");
