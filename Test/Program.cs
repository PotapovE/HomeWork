// 43. Написать программу преобразования десятичного числа в двоичное

using System;

    namespace Test{

        class Program{

            static void Main(){

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

            }

        }

    }