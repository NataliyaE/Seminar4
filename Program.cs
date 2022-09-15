Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

int result = 1;
int number = 1;

Console.WriteLine();

void PowerNumber (int SecondNumber)
{
    if (SecondNumber == 0)
    {
        Console.WriteLine($"{FirstNumber} в степени {SecondNumber} = 1");
    }
    else if (SecondNumber < 0)
    {
        Console.WriteLine($"{FirstNumber} в степени {SecondNumber} не определяется");
    }
    else
    {
        while (number <= SecondNumber)
        {
            result = result * FirstNumber;
            number++;
        }
        Console.WriteLine($"{FirstNumber} в степени {SecondNumber} = {result}");
    }
}
PowerNumber (SecondNumber);
