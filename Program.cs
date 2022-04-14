//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите первое число: ");
string num_1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string num_2 = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string num_3 = Console.ReadLine();
if (Convert.ToInt32(num_1) > Convert.ToInt32(num_2))
{
    if (Convert.ToInt32(num_1) > Convert.ToInt32(num_3))
        Console.Write($"Максимальное число: {num_1}");
    else
        Console.Write($"Максимальное число: {num_3}");
}
else
    if (Convert.ToInt32(num_2) > Convert.ToInt32(num_3))
        Console.Write($"Максимальное число: {num_2}");
    else
        Console.Write($"Максимальное число: {num_3}");