﻿Console.WriteLine("## Operadores Aritméticos ##\n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"soma de x + y = {x + y}");
Console.WriteLine($"subtração de x - y = {x - y}");
Console.WriteLine($"multiplicação de x * y = {x * y}");
double divisao = (double) x / y; 
Console.WriteLine($"divisão de x / y = {divisao}");
Console.WriteLine($"módulo de x % y = {x % y}");

Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de de x e y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor mínimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"Valor máximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno de x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");

Console.ReadKey();