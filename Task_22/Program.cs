

Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
//int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"|Квадрат числа {i, 4} = |{i * i,8}|");
}