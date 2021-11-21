// 41. Выяснить являются ли три числа сторонами треугольника
// a < b + c; b < a + c; c < a + b - треугольник существует, если выполняются эти неравентсва.

bool check (int a, int b, int c){
    if (a < b + c & b < a + c & c < a +b) {return true;}
    return !true;
}
Console.Write(check(5, 11, 5));