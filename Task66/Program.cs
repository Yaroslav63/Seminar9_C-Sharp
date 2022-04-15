Console.WriteLine("Введите число M");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (num1 > num2)
{
    Console.WriteLine("Введены некорректные числа");
}
else
    RecursiyaSumNumbers(num1, num2, sum);

void RecursiyaSumNumbers(int M, int N, int Sum)
{
    if (M > N)
    {
        Console.WriteLine("Сумма чисел равна: " + Sum);
        return;
    }
    Sum += M;
    RecursiyaSumNumbers(M + 1, N, Sum);
}