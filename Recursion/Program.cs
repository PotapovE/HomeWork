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