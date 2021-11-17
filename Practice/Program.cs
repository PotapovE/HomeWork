// Почувствуй себя интерном

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
// string numbers (int a){
//     if (a > 0) {a = a * -1;}
//     int sum = a * -2 + 1; 
//     int [] arr = new int [sum];
//     string res = string.Empty;
//         for (int i = 0; i < arr.Length; i++) {arr [i] = a; a = a+1;}
//         for (int i = 0; i < arr.Length; i++) {res = $"{Convert.ToString(res)} {Convert.ToString(arr[i])}";}
//     return res;
// }
// string valueArr = numbers(-17);
// Console.Write($"А чисел то не мало:\n {valueArr} ");

//  8. Показать четные числа от 1 до N
// string numbers (int a){
//     string res = string.Empty;
//     if (a < 0) {res = $"Число {a} должно быть положительным";}
//     else{
//     int [] arr = new int [a]; int b = 1;    
//         for (int i = 0; i < arr.Length; i++) {arr [i] = b; b = b+1;}
//         for (int i = 0; i < arr.Length; i++) {if (arr[i] % 2 == 0) {res = $"{Convert.ToString(res)} {Convert.ToString(arr[i])}";}}
//     }
//     return res;
// }
// int randomNumb = new Random().Next(1, 100);
// string valueArr = numbers(randomNumb);
// Console.Write($"А чисел то не мало от {randomNumb}:\n {valueArr} ");

//  9. Показать последнюю цифру трёхзначного числа
// int numbers (int a) {return a % 10;}
// int randomNumb = new Random().Next(100, 1000);
// int valueArr = numbers(randomNumb);
// Console.Write($"Последняя цифра от {randomNumb}:\n {valueArr} ");

// 10. Показать вторую цифру трёхзначного числа
// int numbers (int a) {return a = a % 100 / 10;}
// int randomNumb = new Random().Next(100, 1000);
// int valueArr = numbers(randomNumb);
// Console.Write($"Последняя цифра от {randomNumb}:\n {valueArr} ");

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int numbers (int i) {
//     int a = i / 10, b = i % 10;
//     if (a > b) return a;
//     else return b;  
// }
// int randomNumb = new Random().Next(10, 100);
// int valueArr = numbers(randomNumb);
// Console.Write($"Наибольшая цифра числа {randomNumb}:\n {valueArr} ");

// 12. Удалить вторую цифру трёхзначного числа
// string numbers (int i) {
//     int a = i / 100, b = i % 10;
//     return $"{Convert.ToString(a)}{Convert.ToString(b)}";
// }
// int randomNumb = new Random().Next(100, 1000);
// string valueArr = numbers(randomNumb);
// Console.Write($"Результат удаления второй цифры из числа {randomNumb}:\n {valueArr} ");

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// string numbers (int a , int b) {
//     if (a % b == 0) {return $"Число {a} кратно {b}";}
//     else {return $"Число {a} не кратно {b}, а остаток от деления равен {a % b}";}
// }
// int randomNumb = new Random().Next(100, 1000);
// int randomVal = new Random().Next(10, 15);
// string valueArr = numbers(randomNumb, randomVal);
// Console.Write($"{valueArr}");

// 14. Найти третью цифру числа или сообщить, что её нет
// int numbers (int a) {
//     if (a < 0) {a = a*-1;}
//     if (a > 99) {return a = a % 1000 / 100;}
//     else {return a = -1;}
// }
// int randomNumb = new Random().Next(-100, 100);
// int valueArr = numbers(randomNumb);
// Console.Write($"Третья цифра числа {randomNumb}:\n {valueArr}");

// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// bool valBool (int a) {return a % 7 == 0 & a % 23 == 0;}
// int randomNumb = new Random().Next(161, 165);
// bool res = valBool(randomNumb); // 161 сработает как true
// Console.Write($"Cлучайное число {randomNumb}: {res}");

// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
// bool valBool (int a) {return a > 5;}
// int randomNumb = new Random().Next(1, 8);
// bool res = valBool(randomNumb);
// Console.Write($"Cлучайное число {randomNumb}: {res}");

// // 17. По двум введённым числам проверять является ли одно квадратом другого
// bool valBool (int a, int b) {return a == b*b | b == a*a;}
// int randomNumbA = new Random().Next(1, 3),
//     randomNumbB = new Random().Next(3, 5);
// bool res = valBool(randomNumbA, randomNumbB);
// Console.Write($"Cлучайные числа {randomNumbA} и {randomNumbB}: {res}");

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool valBool (bool x, bool y){return !(x | y) == (!x & !y);}
// Console.Write(valBool(true, true));

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int value (int x, int y){
//     int res = 0;
//     if (x == 0 | y == 0) res = -1; // X и Y не могут быть равны 0
//     else if (x > 0 & y > 0) res = 1;
//     else if (x > 0 & y < 0) res = 2;
//     else if (x < 0 & y < 0) res = 3;
//     else if (x < 0 & y > 0) res = 4;
//     return res;
// }
// Console.Write(value(0, 0));

// 20. Ввести номер четверти, показать диапазоны для возможных координат
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

// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом