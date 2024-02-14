Console.WriteLine("## Conversão de tipos ##\n");

/* 
byte -> 1 byte
short -> 2 bytes
int -> 4 bytes
long -> 8 bytes
float -> 4 bytes
double -> 8 bytes
decimal -> 16 bytes
*/

int varInt = 100;
double varDouble = varInt;

Console.WriteLine(varDouble);

int numeroInt = 214567;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

// Cast
double varDouble1 = 12.456;  // 8 byts
int varInt1 = (int)varDouble1;    // 4 bytes

Console.WriteLine(varInt1);

int num1 = 10;
int num2 = 4;
float resultado = (float) num1 / num2;  // 10/4 = 2.5

Console.WriteLine(resultado);  

Console.ReadLine();