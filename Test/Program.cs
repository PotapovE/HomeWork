string ShowN(int n)
{
    if (n <= 0)
    {
        return "0";
    }
    else return $"{ShowN(n - 1)} {n}";
}

System.Console.WriteLine(ShowN(5));