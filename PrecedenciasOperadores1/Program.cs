Console.WriteLine("## Precedência de Operadores ##\n");

int a = 10 - 2 * 3;

Console.WriteLine(a);

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
bool c = !(9 != 8) && (5 >= 7 || 8 >= 6);

Console.WriteLine(b);
Console.WriteLine(c);

int x = 5, y = 6, z = 4;
int calculo = --x * y - ++z;
//              4 * 6 - 5

Console.WriteLine(calculo);

Console.ReadKey();