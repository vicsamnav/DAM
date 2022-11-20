// See https://aka.ms/new-console-template for more information

Console.WriteLine("Introduce el numero a comprobar");
string numero = Console.ReadLine();

InvertirString(numero);

string InvertirString(string numero)
{
    string numeroInvertido = default;

    for(int i=0; i < numero.Length; i++)
    {
        numeroInvertido += numero[numero.Length-1-i];
    }

    return numeroInvertido;
}

string numeroInvertido = InvertirString(numero);

if (numero==numeroInvertido.Reverse())
    Console.WriteLine("Es capicua");
else 
    Console.WriteLine("No es capicua");

