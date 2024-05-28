using NumerosRacionales.Model; 

Console.WriteLine("Demostración de de operaciones con números racionales\n");

Racional r1 = new Racional(2, 5);
Racional r2 = new Racional(3, 8);

Console.WriteLine($"{r1.ComoTexto()} como fraccion es {r1.Fraccion()}");
Console.WriteLine($"{r2.ComoTexto()} como fraccion es {r2.Fraccion()}");
if( r1.EsFraccionPropia() == true)
{
    Console.WriteLine($"{r1.ComoTexto()} si es fracción propia");
}
else
{
    Console.WriteLine($"{r1.ComoTexto()} no es fracción propia");
}

//Ejemplo de realización de suma de racionales
Racional r3 = r1.Sumar(r2); 
Console.WriteLine($"{r1.ComoTexto()} + {r2.ComoTexto()} = {r3.ComoTexto()}");
Console.WriteLine($"{r1.ComoTexto()} + {r2.ComoTexto()} = {r1.Sumar(r2).ComoTexto()}");

//Ejemplo de realización de resta de racionales
Racional r4 = r3.Restar(r2);
Console.WriteLine($"{r3.ComoTexto()} - {r2.ComoTexto()} =  {r4.ComoTexto()}");

//Ejemplo de multiplicación de racionales
Racional r5 = r1.Multiplicar(r2);
Console.WriteLine($"{r1.ComoTexto()} x {r2.ComoTexto()} =  {r5.ComoTexto()}");

//Ejemplo de multiplicación de racionales
Racional r6 = r1.Dividir(r2);
Console.WriteLine($"{r1.ComoTexto()} / {r2.ComoTexto()} =  {r6.ComoTexto()}");

//Console.WriteLine($"{r1.GetNumerador()}/{r1.GetDenominador()}");
//r1.SetNumerador(4);
//r1.SetDenominador(7);
//Console.WriteLine($"{r1.GetNumerador()}/{r1.GetDenominador()}");

//Ejemplo de uso de propiedades
Console.WriteLine($"{r1.Numerador}/{r1.Denominador}");
r1.Numerador = 3;
r1.Denominador = 8;