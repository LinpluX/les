Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int Krat(int num1, int num2)
{
    int result = num1 % num2;
    return result;
}

if (a % b == 0)
{
    Console.WriteLine("Число делится без остатка:");
}
else
{
    Console.WriteLine($"Число {a} делится на {b} с остатком, равным {Krat(a, b)}");
}
