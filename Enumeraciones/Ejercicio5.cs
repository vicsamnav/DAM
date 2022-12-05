
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


static string DibujarMenu()
{
    return "1.Añadir color\n2.Quitar color\n3.Mostar colores\n4.Salir";
}
static int Seleccionar()
{
    int eleccion;
    return  eleccion = int.Parse(Console.ReadLine());
}
bool salir = false;
do{

Console.WriteLine(DibujarMenu());
int eleccion = Seleccionar();
Colores colores = default;
switch(eleccion)
{
    case 1 : 
    {
        Object enum1 = LeerEnum(typeof(Colores),"Dime el color que quieres añadir","Color invalido");
        Console.WriteLine(AñadirColor(enum1));
    }
    break;
    case 2 :
    {
        Object enum2 = LeerEnum(typeof(Colores),"Dime el color que quieres borrar","Color invalido");
        Console.WriteLine(QuitarColor(enum2));
    }
    break;
    case 3: 
     
    break;
    case 4: 
    {
        salir = true;
    }
    break;
}
}while(salir == false);

static string AñadirColor (Object enumNuevo)
{
    Colores colores = default;
    string colorComparar = enumNuevo.ToString();
    string salidaTexto = "El color ha sido añadido";
    if(colorComparar == "Amarillo")
    {
        colores|= Colores.Amarillo;
    }
    else if(colorComparar == "Verde")
    {
        colores|= Colores.Verde;
    }
    else if(colorComparar == "Turquesa")
    {
        colores|= Colores.Turquesa;
    }
    else if(colorComparar == "Marron")
    {
        colores|= Colores.Marron;
    }
    else if(colorComparar == "Naranja")
    {
        colores|= Colores.Rojo;
    }
    else if(colorComparar == "Azul")
    {
        colores|= Colores.Azul;
    }
    else
    {
        salidaTexto = "No has añadido ningun color";
    }
    return salidaTexto;
}

static string QuitarColor (Object enumNuevo)
{
    Colores colores = default;
    string colorComparar = enumNuevo.ToString();
    string salidaTextoo = "El color ha sido borrado";
    if(colorComparar == "Amarillo")
    {
        colores &= ~Colores.Amarillo;
    }
    else if(colorComparar == "Verde")
    {
        colores &= ~Colores.Verde;
    }
    else if(colorComparar == "Turquesa")
    {
        colores &= ~Colores.Turquesa;
    }
    else if(colorComparar == "Marron")
    {
        colores &= ~Colores.Marron;
    }
    else if(colorComparar == "Naranja")
    {
        colores &= ~Colores.Rojo;
    }
    else if(colorComparar == "Azul")
    {
        colores &= ~Colores.Azul;
    }
    else
    {
        salidaTextoo = "No has borrado nada";
    }
    return salidaTextoo;
}



enum Colores : byte
{
    None = 0b_0000_0000,   
    Verde = 0b_0000_0001,   
    Naranja = 0b_0000_0010,   
    Rojo = 0b_0000_0100,   
    Azul = 0b_0000_1000,   
    Amarillo = 0b_0001_0000,
    Marron = 0b_0010_0000,
    Turquesa = 0b_0100_0000,
}  

