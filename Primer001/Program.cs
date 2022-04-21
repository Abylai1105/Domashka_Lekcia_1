int firstNumber;
int secondNumber;
Console.WriteLine("Напишите первое число: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
{
    Console.WriteLine("Равные числа");
}
else
{
    if (firstNumber > secondNumber)
    {
        Console.Write(firstNumber);
        Console.WriteLine("max = first");
    }
    else
    {
        Console.Write(secondNumber);
        Console.WriteLine("max = second");
    }
}