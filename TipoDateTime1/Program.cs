﻿Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// criar uma data específica com formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2023, 02, 14);
Console.WriteLine(dataHoje);

// definir as horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje);

// extrair informações da data atual
DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

// adicionando valores
Console.WriteLine(hoje.AddYears(5));
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(2));
Console.WriteLine(hoje.AddDays(6));
Console.WriteLine(hoje.AddHours(10));
Console.WriteLine(hoje.AddMinutes(4));
Console.WriteLine(hoje.AddSeconds(30));
Console.WriteLine(hoje.AddMilliseconds(2));

// objter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

// data no formato long e short
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();
