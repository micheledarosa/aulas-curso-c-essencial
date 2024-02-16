Console.WriteLine("## Inferência Tipos (var) ##\n");

int idade = 25;
string nome = "Maria";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

/*
Limitações: 
var salario = null;
var titulo;
var salario, imposto, total;

Não posso mudar o tipo após inicializar:
var num = 10;
num = num + 20;
num = "Teste";
*/

Console.ReadKey();

var teste = new Teste();
teste.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("meu método");
    }
}