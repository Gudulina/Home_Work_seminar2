// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Function (int num)
{
    return num / 10 % 10;
}

Console.WriteLine ("Введите трёхзначное число");
string s_n = Console.ReadLine ();
int n = int.Parse (s_n);

Console.WriteLine (Function (n));