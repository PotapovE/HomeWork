// 42. Определить сколько чисел больше 0 введено с клавиатуры
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