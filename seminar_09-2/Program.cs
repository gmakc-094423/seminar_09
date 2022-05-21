// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

Console.WriteLine($"\n");
int n = InputNumbers("Введите n: ");

int m = SumNumber(n);

int SumNumber(int n) 
{
  if (n > 0) return n % 10 + SumNumber(n / 10);
  else return 0;
}
Console.WriteLine($"\n {m}");

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine($"");
double a = InputNumbersDouble("Введите A: ");
double b = InputNumbersDouble("Введите В: ");

double result = Degree(a, b); 
Console.WriteLine($"\n {result}");

double Degree(double a, double b)
{
  // Console.Write($"a={a}, b={b};   ");
  if (b > 1) return a * Degree(a, b-1);
  // Console.Write(a + " ");
  return a;
}

double InputNumbersDouble(string input) 
{
  Console.Write(input);
  double output = Convert.ToDouble(Console.ReadLine());
  return output;
}
