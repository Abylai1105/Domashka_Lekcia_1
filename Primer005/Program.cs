int number;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
int lastdigit = (number % 10);
Console.WriteLine("Посделняя цифра: ");
Console.WriteLine(lastdigit);