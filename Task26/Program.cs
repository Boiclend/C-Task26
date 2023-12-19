// Напишите функцию, которая принимает два целых числа n и k и возвращает число, содержащее k первых цифр числа n.

int Message(string text) 
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int number = Message("Введите число: ");
string s = number.ToString(); // привожу число к строке, что бы узнать длину
int ranks = Message("Сколько разрядов показать?: ");
if(ranks > s.Length) {
    Console.WriteLine("Введенное количество разрядов превышает само число");
    return;
}
int temp = 1;
for (int i = 0; i < s.Length - ranks; i++)
{
    temp = temp * 10;
}
Console.WriteLine($"разряды: {number / temp}");