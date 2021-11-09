Random random = new Random();
 
//Получить случайное число (в диапазоне от 0 до 10)
int value = random.Next(100, 999);
Console.WriteLine($"Ваше число: {value}");
string Number = Convert.ToString(value);
string numPosition(string number,  int position)
{
    string result = string.Empty;
    result = result + number[position];
    return result;
}
int FN=Convert.ToInt32(numPosition(Number, 0));
int TN=Convert.ToInt32(numPosition(Number, 2));
Console.WriteLine($"Оно же только преобразованное: ");
Console.Write(FN);
Console.Write(TN);




