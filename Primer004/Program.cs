int number;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
int num = 2;
while (num <= number)
{
    int result = num % 2;
    if (result !=1)
    {
        Console.WriteLine("Четное " + num);
        num++;
    }
    else
    {
        num++;
    }
}