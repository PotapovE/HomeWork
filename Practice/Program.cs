// Почувствуй себя интерном
/*//    00. Вывести квадрат числа
int sq (int a) => a*a;
Console.Write(sq(12));
*/
/*//    01. По двум введённым числам проверять является ли первое квадратом второго
bool value (int a, int b) => a == b*b;
Console.Write(value(24, 5));
*/
/*//    02. Даны два числа. Показать большее и меньшее число
string value (int a, int b){
    string outValue = string.Empty;
    if (a > b) {outValue = $"{a} > {b}";}
    else {outValue = $"{b} > {a}";}
    return outValue;
}
Console.Write(value(24, 5));
*/
/*//    03. По введенному номеру дня недели вывести его название
string weekDay (int a){
    string outDay = string.Empty;
    string [] arrDay = new string [] {"-1", "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
    if (a > 0 & a < 8) {outDay = $"{arrDay[a]}";}
    else {outDay = $"-1";} 
    return outDay;  
}
Console.Write(weekDay(0));
*/ 
/*//    04. Найти максимальное из трех чисел
int value (int a, int b, int c){
    int outMax = a;
    if (b > outMax) outMax = b;
    if (c > outMax) outMax = c;
    return outMax;
}
Console.Write($"Максимальное число {value(-12, -17, -14)}");
*/
/*//    05. Написать программу вычисления значения функции y=f(a)
double outSin (double degrees){
    double angle = Math.PI * degrees / 180.0;
    return Math.Sin(angle);
}
double Sin = outSin(270);
Console.Write($"Синус заданного угла = {Sin}");
*/
/*//    06. Выяснить является ли число чётным
bool value (int a) => a % 2 == 0;
Console.Write(value(13));
*/
/*//    07. Показать числа от -N до N
string numbers (int a){
    if (a > 0) {a = -a;}
    int sum = -2 * a + 1; 
    string res = string.Empty;
        for (int i = 0; i < sum; i++) {res = $"{res} {a}"; a++;}
    return res;
}
Console.Write(numbers(17));
*/
/*//    08. Показать четные числа от 1 до N
string numbers (int a){
    int b = 1;
    string res = string.Empty;
    if (a < 0) {res = $"-1";}
    else{
        for (int i = 0; i < a; i++) {
            if (b % 2 == 0) {res = $"{res} {b}"; b++;}
            else b++;
        }
    }
    return res;
}
Console.Write(numbers(2));
*/
/*//    09. Показать последнюю цифру трёхзначного числа
int numbers (int a) => a % 10;
Console.Write(numbers(125));
*/
/*//    10. Показать вторую цифру трёхзначного числа
int numbers (int a) => a % 100 / 10;
Console.Write(numbers(125));
*/
/*//    11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int numbers (int i) {
    int a = i / 10, b = i % 10;
    if (a > b) return a;
    else return b;  
}
int randomNumb = new Random().Next(10, 100);
Console.Write($"{randomNumb} {numbers(randomNumb)}");
*/
/*//    12. Удалить вторую цифру трёхзначного числа
string numbers (int i) {
    int a = i / 100, b = i % 10;
    return $"{a}{b}";
}
int randomNumb = new Random().Next(100, 1000);
Console.Write($"{randomNumb} {numbers(randomNumb)}");
*/
/*//    13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
string numbers (int a , int b) {
    if (a % b == 0) {return $"True";}
    else {return $"False = {a % b}";}
}
int randomNumb = new Random().Next(100, 1000),
    randomVal = new Random().Next(10, 15);
Console.Write($"{randomNumb} % {randomVal} == 0 {numbers(randomNumb, randomVal)}");
*/
/*//    14. Найти третью цифру числа или сообщить, что её нет
int numbers (int a) {
    if (a < 0) {a = -a;}
    if (a > 99) {return a = a % 1000 / 100;}
    else {return a = -1;}
}
int randomNumb = new Random().Next(-100, 100);
Console.Write($"Третья цифра числа {randomNumb}:\n {numbers(randomNumb)}");
*/

// Почувствуй себя джуном
/*//    15. Дано число. Проверить кратно ли оно 7 и 23
bool valBool (int a) => a % 7 == 0 & a % 23 == 0;
int randomNumb = new Random().Next(161, 165);
Console.Write($"Cлучайное число {randomNumb}: {valBool(randomNumb)}");
*/
/*//    16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
bool valBool (int a) => a > 5;
int randomNumb = new Random().Next(1, 8);
Console.Write($"Cлучайное число {randomNumb}: {valBool(randomNumb)}");
*/
/*//    17. По двум введённым числам проверять является ли одно квадратом другого
bool valBool (int a, int b) => a == b*b | b == a*a;
int randomNumbA = new Random().Next(1, 3),
    randomNumbB = new Random().Next(3, 5);
Console.Write($"Cлучайные числа {randomNumbA} и {randomNumbB}: {valBool(randomNumbA, randomNumbB)}");
*/
/*//    18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool valBool (bool x, bool y) => !(x | y) == (!x & !y);
Console.Write(valBool(true, true));
*/
/*//    19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int value (int x, int y){
    int res = 0;
    if (x == 0 | y == 0) res = -1; // X и Y не могут быть равны 0
    else if (x > 0 & y > 0) res = 1;
    else if (x > 0 & y < 0) res = 2;
    else if (x < 0 & y < 0) res = 3;
    else if (x < 0 & y > 0) res = 4;
    return res;
}
Console.Write(value(0, 0));
*/
/*//    20. Ввести номер четверти, показать диапазоны для возможных координат
string value (int x, int y){
    string res = string.Empty;
    if (x == 0 | y == 0) res = $"-1"; // X и Y не могут быть равны 0
    else if (x > 0 & y > 0) res = $"1; x(0, +▲), y(0, +▲)";
    else if (x > 0 & y < 0) res = $"2; x(0, +▲), y(0, -▲)";
    else if (x < 0 & y < 0) res = $"3; x(0, -▲), y(0, -▲)";
    else if (x < 0 & y > 0) res = $"4; x(0, -▲), y(0, +▲)";
    return res;
}
Console.Write(value(1, 1));
*/
/*//    21. Программа проверяет пятизначное число на палиндром.
bool valBool (int a) => a % 10 == a % 100000 / 10000 & a % 100 / 10 == a % 10000 / 1000;
Console.Write(valBool(13331));
*/
/*//    22. Найти расстояние между точками в пространстве 2D/3D
double value (int xa, int ya, int za, int xb, int yb, int zb)
=> Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
Console.Write(value(2, 4, 0, 2, 2, 0));
*/

// Почувствуй себя мидлом
/*//    23. Показать таблицу квадратов чисел от 1 до N 
string value (int n){
    string res = string.Empty;
    int sq = 1;
    for (int i = 0; i < n; i++) {res = $"{res} {sq*sq}"; sq++;}
    return res;
}
Console.Write(value(10));
*/
/*//    24. Найти кубы чисел от 1 до N
string value (int n){
    string res = string.Empty;
    int cb = 1;
    for (int i = 0; i < n; i++) {res = $"{res} {Math.Pow(cb, 3)}"; cb++;}
    return res;
}
Console.Write(value(10));
*/
/*//    25. Найти сумму чисел от 1 до А
int value (int a) => a = ((a*(a+1))/2);
Console.Write(value(4));
*/
/*//    26. Возведите число А в натуральную степень B используя цикл
int value (int a, int b){
    int res = a;
    for (int i = 1; i < b; i++) {res = res * a;}
    return res;
}
Console.Write(value(-4, 2));
*/
/*//    27. Определить количество цифр в числе
int value (string n){
    int numbers = 0;
    for (int i = 0; i < n.Length; i++) {numbers ++;}
    return numbers;
}
Console.Write(value("12345789"));
*/
/*//    28. Подсчитать сумму цифр в числе
int value (int n){
    int sum = 0;
    while (n != 0) {sum += n % 10; n = n / 10;}
    return sum;
}
Console.Write(value(22345343));
*/
/*//    29. Написать программу вычисления произведения чисел от 1 до N
int func29 (int N){
int result = 1;
    for (int i=1; i<=N; i++) {result = result * i;}
    return result;
}
Console.WriteLine(func29(4));
*/
/*//    30. Показать кубы чисел, заканчивающихся на четную цифру
string value (int n){
    string res = string.Empty;
    int cb = 1;
    for (int i = 0; i < n; i++) {
        if (cb % 2 == 0){
        res = $"{res} {Math.Pow(cb, 3)}"; cb++;}
        else cb++;
    }
    return res;
}
Console.Write(value(10));
*/

// Почувствуй себя сеньором
/*//    31. Задать массив из 8 элементов и вывести их на экран 
int [] array = new int [8];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
Console.Write(value(array));
*/
/*//    32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
int [] array = new int [8];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(0,2);}
}
FillArr (array);
Console.Write(value(array));
*/
/*//    33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int [] array = new int [12];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(-9,10);}
}
int sumPlus (int [] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr [i] > 0) {sum += arr[i]; }
    }
    return sum;
}
int sumMin (int [] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr [i] < 0) {sum += arr[i]; }
    }
    return sum;
}

FillArr (array);
Console.Write(value(array));
Console.Write($"\nСумма положительных = {sumPlus(array)}\nСумма отрицательных = {sumMin(array)}");
*/
/*//    34. Написать программу замену элементов массива на противоположные
int [] array = new int [5];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(-9,10);}
}
void RevArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = -arr[i];}
}

FillArr (array);
RevArr (array);
Console.Write(value(array));
*/
/*//    35. Определить, присутствует ли в заданном массиве, некоторое число 
int [] array = new int [3];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(0,6);}
    }
bool findA (int [] arr, int a){
    for (int i = 0; i < arr.Length; i++){
        if (a == arr[i]) return true;
    }
    return !true;
}

FillArr (array);
Console.Write(value(array));
Console.WriteLine($"\n{findA (array, 5)}");
*/
/*//    36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] array = new int [5];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(100,1000);}
}
int sumEven (int [] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr [i] % 2 == 0) {sum ++; }
    }
    return sum;
}
int sumOdd (int [] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr [i] % 2 != 0) {sum ++; }
    }
    return sum;
}

FillArr (array);
Console.Write(value(array));
Console.Write($"\nКоличество четных = {sumEven(array)}\nКоличество нечетных = {sumOdd(array)}");
*/
/*//    37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] array = new int [5];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(1,15);}
}
int sumValue (int [] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr [i] >= 10 & arr[i] <= 99) {sum ++; }
    }
    return sum;
}

FillArr (array);
Console.Write(value(array));
Console.Write($"\nКоличество чисел из отрезка = {sumValue(array)}");
*/
/*//    38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] array = new int [5];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(1,10);}
}
int sumOdd (int [] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++){
        if (i % 2 != 0) {sum += arr[i]; }
    }
    return sum;
}

FillArr (array);
Console.Write(value(array));
Console.Write($"\nСумма чисел на нечетных индексах = {sumOdd(array)}");
*/
/*//    39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int [] array = new int [10];
string value (int [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (int [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().Next(-9,10);}
}
string valueRes (int [] arr){
    string valRes = string.Empty;
    int res = 0, x = 0, y = arr.Length -1;
    while (x < y) {res = arr[x] * arr [y]; x++; y--; valRes = $"{valRes} {res}";}
    return valRes;
}

FillArr (array);
Console.Write(value(array));
Console.Write($"\n{valueRes(array)}");
*/
/*//    40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double [] array = new double [5];
string value (double [] arr){
    string res = string.Empty;
    for (int i = 0; i < arr.Length; i++) {res = $"{res} {arr[i]}";}
    return res;
}
void FillArr (double [] arr){
    for (int i = 0; i < arr.Length; i++) {arr[i] = new Random().NextDouble()*1000;}
}
double sum (double [] arr){
    double min = arr [0], max = arr [0];
    for (int i = 0; i < arr.Length; i++){
        if (arr [i] > max) {max = arr[i];}
        if (arr [i] < min) {min = arr[i];}
    }
    return max - min;
}

FillArr (array);
Console.Write(value(array));
Console.Write($"\nРазница = {sum(array)}");
*/

// Почувствуй себя лидом
/*//    41. Выяснить являются ли три числа сторонами треугольника
// a < b + c; b < a + c; c < a + b - треугольник существует, если выполняются эти неравентсва.

bool check (int a, int b, int c) => a < b + c & b < a + c & c < a +b;
Console.Write(check(5, 9, 5));
*/
/*//    42. Определить сколько чисел больше 0 введено с клавиатуры
Console.Write("Enter nambers: ");
string? value = Console.ReadLine();
if (value == null) value = "0";

int count (string str){
    int sum = 0;
    for (int i = 0; i < str.Length; i++){
        if (str.Substring(i, 1) != "0"){sum++;}
    }
    return sum;
}

Console.WriteLine($"Count: {count(value)}");
*/
/*//    43. Написать программу преобразования десятичного числа в двоичное
                string value (int n){

                    string res = string.Empty;
                    while (n > 0)
                    {
                        int ost = n % 2;
                        res = $"{ost}{res}";
                        n = n/2;
                    }
                    return res;
                }
                Console.Write(value(102));
*/

