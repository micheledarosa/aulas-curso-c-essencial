Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string";
valor = "Isto é uma string alterada";

// StringBuilder - para alterar strings

/*
OBJECT - Quando não temos informações 
sobre os tipos de dados que desejamos usar

object nota = 10;
object valor1 = 8.55m;
object nome1 = "Maria";
object ativa = true;
object letra = 'A'; 
*/

// DYNAMIC - Útil para recursos avançados como Reflection ou DLR
dynamic nota = 10;
dynamic valor1 = 8.55m;
dynamic nome1 = "Maria";
dynamic ativa = true;
dynamic letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(valor1);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

Console.ReadLine();
