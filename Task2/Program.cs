//Task2
 Console.Clear();
Console.Write("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
{
Console.WriteLine (" {0} max", n);
Console.WriteLine (" {0} min", m);
}


else 
{
Console.WriteLine (" {0} max", m);
Console.WriteLine (" {0} min", n);
}