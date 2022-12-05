//Task 18
Console.Clear();
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n; i+= 2)
if(i % 2 == 0)
Console.WriteLine(i);
