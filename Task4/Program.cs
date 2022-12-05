//task4
Console.Clear();
Console.Write("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int b = Convert.ToInt32(Console.ReadLine());

if(n > m && n > b)
Console.WriteLine(n);
else if (m > b)
Console.WriteLine(m);
else 
Console.WriteLine(b);
