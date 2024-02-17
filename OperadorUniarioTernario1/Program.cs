Console.WriteLine("## Operador Uniário e Ternário ##\n");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

// ----------------------------

Console.WriteLine("Informe um número: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado1 = temp > 27 ? "quente" : "normal";

Console.WriteLine($"O tempo está {resultado1}\n");

// ----------------------------

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string resultado2 = x > y ? "x é maior que y" 
                  : x < y ? "x é menor que y"    
                  : x == y ? "x é igual a y" 
                  : "Sem resultado";

Console.WriteLine(resultado2);

Console.ReadKey();