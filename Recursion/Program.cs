/*//    66. Показать натуральные числа от 1 до N, N задано

string ShowNaturalNumbers(int n)
{
    if (n <= 1) return "1";
    else return $"{ShowNaturalNumbers(n - 1)} {n}";
}

Console.WriteLine(ShowNaturalNumbers(6));
*/

