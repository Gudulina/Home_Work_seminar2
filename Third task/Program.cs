// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber (int num)
{
    Console.Write ($"{num} --> ");
    int tr_num = -1;
    string text;
    while (num > 99)
    {
        tr_num =  num % 10;
        num = num/10;
    }
    text = $"{tr_num}";
    if (tr_num == -1)
    {
        text = "Третьей цифры нет!";
    }
    Console.WriteLine (text);
}

ThirdNumber (358);
ThirdNumber (354351);
ThirdNumber (22);