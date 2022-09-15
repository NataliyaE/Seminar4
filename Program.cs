Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int count = 0;
    int result = 0;
    int temp = 0;
    while (num > 0)
    {
        temp = num % 10;
        num = (num - temp) / 10;
        result = result + temp;
        count++;
    }
    return result;
}
Console.WriteLine(SumDigit(number));
