Console.WriteLine("## Operadores Incremento e Decremento ##\n");

int x = 0;

Console.WriteLine($"x = {x}");

// pós-incremento -> primeiro resolve, depois incrementa
int resultado1 = x++ + 10;

Console.WriteLine($"pós-incremento => {resultado1}");
Console.WriteLine($"valor de x => {x}\n");

// pré-incremento -> primeiro incrementa, depois resolve
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;

Console.WriteLine($"pré-incremento => {resultado2}");
Console.WriteLine($"valor de y => {y}\n");

// pós-decremento -> primeiro resolve, depois decrementa
int a = 0;
Console.WriteLine($"a = {a}");
int resultado3 = a-- + 10;

Console.WriteLine($"pós-decremento => {resultado3}");
Console.WriteLine($"valor de a => {a}\n");

// pré-decremento -> primeiro decrementa, depois resolve
int b = 0;
Console.WriteLine($"b = {b}");
int resultado4 = --b + 10;

Console.WriteLine($"pré-decremento => {resultado4}");
Console.WriteLine($"valor de b => {b}\n");

Console.ReadKey();