// See https://aka.ms/new-console-template for more information



string RecogeContraseña(){
ConsoleKeyInfo teclaFisica;
char character = default;
string frase = "";
do
{
    teclaFisica = Console.ReadKey(true);
    frase = frase+character;

    if  (teclaFisica.Key != ConsoleKey.Enter)
    {
        Console.Write("*");
         character = teclaFisica.KeyChar;
    }
} while (teclaFisica.Key != ConsoleKey.Enter);
return frase;
}
string password = "";
bool salir = false;
string passwordEntrar = default;
void RegistrarseSistema()
{
        Console.Write("Contraseña: ");
        password = RecogeContraseña();
        Console.WriteLine("");
        Console.Write("Comprobar contraseña: ");
        string comprobarPassword = RecogeContraseña();
        Console.WriteLine("");
        if (password == comprobarPassword)
        Console.WriteLine("Valida");
        else 
        {
            Console.WriteLine("No valida");
            password = "";
        }
}
void EntrarSistema()
{
     if (password == "")
        Console.WriteLine("Registrate primero");
        else  
        {
            Console.WriteLine("Introducir contraseña");
            passwordEntrar = RecogeContraseña();
            if(passwordEntrar == password)
            {
                Console.WriteLine("");
                Console.WriteLine("Contraseña correcta");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
                Console.WriteLine("");
            }
                
        }
}

int ElegirMenu ()
{
    int eleccion = default;
    Console.WriteLine("1-Registrarse en el sistema");
    Console.WriteLine("2-Entrar al sistema");
    Console.WriteLine("3-Salir del programa");
    eleccion = int.Parse(Console.ReadLine());
    return eleccion;
}


do
{
    int eleccion = ElegirMenu();
    switch (eleccion)
    {
        case 1 : 
            RegistrarseSistema();
        break;

        case 2 :
            EntrarSistema();
        break;

        case 3 :
            salir = true;
        break;
    }
    

}
 while(salir==false);