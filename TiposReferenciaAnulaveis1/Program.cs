Console.WriteLine("## Tipos de Referência Anuláveis ##\n");

string? nome = null;
string sobrenome = "";

Console.WriteLine(nome?.ToUpper());
Console.WriteLine(sobrenome.ToUpper());

Console.ReadKey();