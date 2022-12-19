// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

internal class Program
{
    public static void Main(string[] args)
    {
        string fecha;

        Console.WriteLine("Introduce una fecha: ");
        fecha = Console.ReadLine();
        string patronFecha = @"^\d{1,2}[/-]\d{1,2}[/-]\d{4}$";
        bool validar = Validar(patronFecha,fecha);

        if(validar == true)
        {
            Console.WriteLine("La fecha es valida");
        }
        else
        {
            Console.WriteLine("La fecha no es valida");
        }
        string matricula;
        

        Console.WriteLine("Escribe la matricula");
        matricula = Console.ReadLine().ToUpper();
        string patronMatricula1 = @"^[A-Z]{2}[-][0-9]{4}[-][A-Z]{2}$";
        validar = Validar(patronMatricula1,matricula);
       
        if(validar == true)
        {
            Console.WriteLine("La matricula es valida");
        }
        else 
        {
            string patronMatricula2 = @"^[0-9]{4}[-][A-Z]{3}$";
            validar = Validar(patronMatricula2,matricula);
            if(validar ==true)
            {
                Console.WriteLine("La matricula es valida");
            }
            else
            {
                Console.WriteLine("La matricula no es valida");
            }
        }

        Console.WriteLine("Introduce un numero real con exponente");
        string numReal = Console.ReadLine();
        string patronNumReal = @"^[0-9]{0,2}[,]?[0-9]*[E]{1}[0-9]*$";
        validar = Validar(patronNumReal,numReal);

        if(validar == true)
        {
            Console.WriteLine("El numero real con exponente es valido");

        }
        else
        {
            Console.WriteLine("El numero real con exponente es invalido");
        }
    }

    static bool Validar (string patron,string palabraAValidar)
    {
        bool validar = false;
        Regex regex =  new Regex (patron);
        if(regex.IsMatch(palabraAValidar))
        {
            validar = true;
        }
        else
        {
            validar = false;
        }
    return validar;

    }

  
    
    
}



