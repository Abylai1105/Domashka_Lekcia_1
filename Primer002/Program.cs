int number1;
int number2;
int number3;
Console.Write("Введите первое число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
number3 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    if(number1 == number3)
    {
        Console.WriteLine("Равные числа");
    }
    
}
else
{
    if(number1 > number2)
    {
        if(number1 > number3)
        {
            Console.Write(number1);
            Console.WriteLine( "Первое больше" );
        }
        else
        {
            Console.Write(number3);
            Console.WriteLine( "Третье больше" );
        }
    }
    else
    {
        if(number2 > number3)
        {
            Console.Write(number2);
            Console.WriteLine( "Второе больше" );
        }
        else
        {
            Console.Write(number3);
            Console.WriteLine( "Третье больше" );
        }
    }
}