Console.WriteLine("## Nullable Types ##\n");

/*
int valor = null;
Console.WriteLine(valor);
*/

Nullable<int> a = null;
Nullable<double> b = null;
Nullable<bool> c = null;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

// simplificado
int? d = null;
double? e = null;
bool? f = null;

// para atribuir um tipo anulável a um tipo não anulável
int? g = null;
int h = g ?? 0;
Console.WriteLine(h);

// declarar todas as variáveis como nullable
/*
int? i = 4;
int j = 3;
int k = x * y;
*/

int? i = 4;
int? j = 3;
int? k = i * j;
Console.WriteLine(k);

// HasValue
int? l = 100;

if (l.HasValue)
{
    Console.WriteLine($"l = {l.Value}");
}
else
{
    Console.WriteLine("l não possui um valor (null)");
}

Console.ReadKey();