﻿// Почувствуй себя интерном

// 0. Вывести квадрат числа
// int qs (int a){return a*a;}
// int res = qs(12); 
// Console.Write(res);

//  1. По двум введённым числам проверять является ли первое квадратом второго
// string value (int a, int b){
//     string outValue = string.Empty;
//     if (a == b*b) {outValue = $"{a} квадрат от {b}";}
//     else {outValue = $"{a} не является квадратом от {b}";}
//     return outValue;
// }
// string res = value (24, 5);
// Console.Write(res);

//  2. Даны два числа. Показать большее и меньшее число
// string value (int a, int b){
//     string outValue = string.Empty;
//     if (a > b) {outValue = $"{a} больше {b}";}
//     else {outValue = $"{b} больше {a}";}
//     return outValue;
// }
// string res = value (25, 6);
// Console.Write(res);

//  3. По введенному номеру дня недели вывести его название
// string weekDay (int a){
//     string outDay = string.Empty;
//     string [] arrDay = new string [] {"-1", "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
//     if (a > 0 & a < 8) {outDay = $"Сегодня {arrDay[a]}";}
//     else {outDay = $"Упс, что-то пошло не так";} 
//     return outDay;  
// }
// string res = weekDay(0);
// Console.Write(res);
 
//  4. Найти максимальное из трех чисел
// int value (int a, int b, int c){
//     int outMax = 0;
//     int [] arrValue = new int []{a, b, c};
//     for (int i = 0; i < arrValue.Length; i++)
//     {
//         if (arrValue[i] > outMax) {outMax = arrValue[i];}
//     }
//     return outMax;
// }
// int res = value(113, 17, 1);
// Console.Write($"Максимальное число {res}");

//  5. Написать программу вычисления значения функции y=f(a)
// double outSin (double degrees){
//     double angle = Math.PI * degrees / 180.0;
//     return Math.Sin(angle);
// }
// double Sin = outSin(270);
// Console.Write($"Синус заданного угла = {Sin}");

//  6. Выяснить является ли число чётным
// string value (int a){
//     string outValue = string.Empty;
//     if (a % 2 == 0) {outValue = "четное";}
//     else {outValue = "нечетное";}
//     return outValue;
// }
// string res = value(14);
// Console.Write($"Число {res}");

//  7. Показать числа от -N до N
string numbers (int a){
    if (a > 0) {a = a * -1;}
    int sum = a * -2 + 1; 
    int [] arr = new int [sum];
    string res = string.Empty;
        for (int i = 0; i < arr.Length; i++) {arr [i] = a; a = a+1;}
        for (int i = 0; i < arr.Length; i++) {res = $"{Convert.ToString(res)} {Convert.ToString(arr[i])}";}
    return res;
}
string valueArr = numbers(-17);
Console.Write($"А чисел то не мало:\n {valueArr} ");

//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет