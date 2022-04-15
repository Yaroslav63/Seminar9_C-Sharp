void RecursiyaNum(int M, int N)
{
    if (N < M)
    {
        return;
    }
    else
    {
        if (N > M)
        {
            System.Console.Write($"{N}, ");
        }
        else
        {
            System.Console.Write($"{N}");
        }
        RecursiyaNum (M, --N);
    }
}
RecursiyaNum(5, 9);