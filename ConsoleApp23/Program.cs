int[] numbers = {20,22,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
int evenNumbers = numbers.Where(s => s % 3 == 0).Count();
Console.WriteLine($"Замен: {evenNumbers}");
numbers = numbers.Select(ToZero).ToArray();

foreach (var item in numbers)
{
    Console.Write(item+" ");
}

int ToZero(int n)
{
    if (n % 3 == 0) n = 0;

    return n;

}