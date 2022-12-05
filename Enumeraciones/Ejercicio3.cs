// See https://aka.ms/new-console-template for more information
//Ejercicio3

static Object LeerEnum(Type tipo, string texto, string textoError)
{
    bool comprobarEnum = true;
    string respuesta ;
    string[] listaItems = Enum.GetNames(tipo);
    do
    {
        Console.WriteLine(texto + " :");
        respuesta = Console.ReadLine();
        comprobarEnum = Enum.IsDefined(tipo, respuesta);
        if (comprobarEnum == true)
        {
            comprobarEnum = true;
        }
        else
        {
            Console.WriteLine(textoError);
            comprobarEnum = false;
            foreach (string c in listaItems)
            {
                Console.WriteLine(c);
            }
        }
    } while (comprobarEnum == false);

    return Enum.Parse(tipo, respuesta);
}

