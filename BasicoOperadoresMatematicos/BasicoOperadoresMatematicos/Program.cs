// See https://aka.ms/new-console-template for more information

int a, b, total;



Console.WriteLine("Digite o primeiro numero: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
b = Convert.ToInt32(Console.ReadLine());

total = a + b;

Console.WriteLine("A soma de a + b = " + total);

Console.WriteLine("A soma de a + b = " + (a + b));

Console.WriteLine("A soma de a - b = " + (a - b));

Console.WriteLine("A soma de a - b = " + (a * b));

Console.WriteLine("A soma de a - b = " + (a / b));

Console.WriteLine("A soma de a - b = " + (a % b));