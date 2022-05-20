// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Day (int number)
{
    string text = "Будний день";
    if (number == 6 || number == 7)
    {
        text = "Выходной";
    }
    Console.WriteLine ($"{number} - {text}");
}

Day (1);
Day (2);
Day (3);
Day (4);
Day (5);
Day (6);
Day (7);