// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void Function ()
{
    int number = new Random ().Next(100, 1000);
    Console.WriteLine($"{number} --> {number / 100}{number % 10}");
}

Function();