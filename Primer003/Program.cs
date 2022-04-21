int number;
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
int numberEven = number % 2;
if( numberEven == 1 )
{
    Console.WriteLine("Не четное");
}
else
{
    Console.WriteLine("Четное");
}