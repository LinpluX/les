Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель, который будет меньше первого числа : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Krat(int num1, int num2)
{if (num1%num2==0)
{
    Console.WriteLine("Число делится без остатка:");
    return num1%num2;
}
else
{
    Console.WriteLine("Число делится с остатком, остаток равен:");
    return num1/num2;;
}
}
Console.WriteLine(Krat(a,b));