//Task10
Console.Write("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x / 100;
int x3 = x % 10;

int x4 = (x - (x1 * 100 + x3));

Console.WriteLine(x4 / 10);

