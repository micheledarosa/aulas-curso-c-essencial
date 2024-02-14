﻿Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.WriteLine(idade);

Console.Write(nome);
Console.Write(idade);

Console.WriteLine();

// Escreve na mesma linha 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos.");

Console.WriteLine();
Console.WriteLine("----------");

// concatenação usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos.");
Console.Write(nome + " tem " + idade + " anos.");

Console.WriteLine();
Console.WriteLine("---------");

// interpolação de strings: $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos.");

// place holders usa {} com numeração com início em zero
Console.WriteLine("{0} tem {1} anos.", nome, idade);

Console.ReadLine();