// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

Console.WriteLine($"\n");
int n = InputNumbers("Введите n: ");

PrintNumber(n);

void PrintNumber(int n) 
{
  if (n < 0) return;
  PrintNumber(n - 1);
  Console.Write(n + " ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
Console.WriteLine();

while (true)
{
int m = InputNumbers("Введите m: ");
int n1 = InputNumbers("Введите n: ");

if (m > n1) 
{
  // n = m;
  // m = n1;
  // n1 = n;
}
else{ 
PrintNumber1(m, n1);
break;
}
}

void PrintNumber1(int m, int n1) 
{
  if (n1 < m) return;
  PrintNumber1(m, n1 - 1);
  Console.Write(n1 + " ");
}