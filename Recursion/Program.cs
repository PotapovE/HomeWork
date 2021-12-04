/*//    66. Показать натуральные числа от 1 до N, N задано

string ShowNaturalNumbers(int n)
{
    if (n <= 1) return "1";
    else return $"{ShowNaturalNumbers(n - 1)} {n}";
}

Console.WriteLine(ShowNaturalNumbers(6));
*/
/*//    67. Показать натуральные числа от N до 1, N задано
string ShowNaturalNumbers(int n)
{
    string vulueNumbers = string.Empty;
    if (n == 1) return "1";
    if (n <= 0) {vulueNumbers = $"{n} {ShowNaturalNumbers(n + 1)}";}
    else vulueNumbers = $"{n} {ShowNaturalNumbers(n - 1)}";
    return vulueNumbers;
}

Console.WriteLine(ShowNaturalNumbers(6));
*/
/*//    68. Показать натуральные числа от M до N, N и M заданы
string ShowNaturalNumbers(int m, int n)
{
    string vulueNumbers = string.Empty;
    if (n == m) return $"{m}";
    if (m < n) vulueNumbers = $"{m} {ShowNaturalNumbers(m + 1, n)}";
    else vulueNumbers = $"{m} {ShowNaturalNumbers(m - 1, n)}";
    return vulueNumbers;
}

Console.WriteLine(ShowNaturalNumbers(-10, -5));
*/
/*//    69. Найти сумму элементов от M до N, N и M заданы
int SumNumbers(int m, int n)
{
    if (n == m) return m;
    if (m < n) m += SumNumbers(m + 1, n);
    else m += SumNumbers(m - 1, n);
    return m;
}

Console.WriteLine(SumNumbers(-1, -5));
*/