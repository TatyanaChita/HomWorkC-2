// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string s = "num";
for (int num = 0; num < s.Lenght; num++)
{
  Console.Write($"{s[num]}, ");  
}
Console.Write("\b\b ");