//task 17
Console.Clear();
Console.Write("Введите номер четверти ");
int n = Convert.ToInt32(Console.ReadLine());


while (n > 4 || n < 1)
{
    Console.Write("Вы ошиблись!\nВведите номер четверти ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n == 1)
Console.WriteLine("X > 0  Y > 0");
else if (n == 2)
Console.WriteLine("X < 0  Y > 0");
else if (n == 3)
Console.WriteLine("X < 0  Y < 0");
else if (n == 4)
Console.WriteLine("X > 0  Y < 0");

