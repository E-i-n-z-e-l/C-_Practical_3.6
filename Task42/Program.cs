// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// double Factorial1(int n)
// {
//  if(n == 1) return 1;
//  else return n * Factorial1(n-1);
// }
// Console.WriteLine(Factorial1(4));

int Remainder(int num)
{
    if (num % 2 == 1) return 1;
    else return Remainder(num / 2);
}
Console.WriteLine(Remainder(12));



