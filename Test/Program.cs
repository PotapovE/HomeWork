// Найти сумму цифр числа

int sum(int n)
{
    n = Math.Abs(n);
    if (n > 9) return n % 10 + sum(n / 10);
    return n % 10;    
}

Console.WriteLine(sum(-1095));