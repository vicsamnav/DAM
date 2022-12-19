using System.Text.RegularExpressions;

Console.WriteLine("Introduce numero de cuenta bancaria: ");
string numCuenta = Console.ReadLine();
Console.WriteLine("");

string patronCuentaCompleta = @"^[0-9]{4}[ ]{1}[0-9]{4}[ ]{1}[0-9]{2}[ ]{1}[0-9]{10}$";








bool validar = Validar(patronCuentaCompleta, numCuenta);

if (validar == true)
{
    string[] cuentaCompleta = numCuenta.Split(' ');



    int entidad = int.Parse(cuentaCompleta[0]);
    int sucursal = int.Parse(cuentaCompleta[1]);
    string digitosControl = cuentaCompleta[2];
    int numeroCuenta = int.Parse(cuentaCompleta[3]);

    int[] arrayEntidad = PasarAArray(entidad, cuentaCompleta[0].Length);
    int[] arraySucursal = PasarAArray(sucursal, cuentaCompleta[1].Length);
    int[] arrayNumeroCuenta = PasarAArray(numeroCuenta, cuentaCompleta[3].Length);
    int digito1Control = 11 - ((arrayEntidad[0] * 4 + arrayEntidad[1] * 8 + arrayEntidad[2] * 5 + arrayEntidad[3] * 10 + arraySucursal[0] * 9 + arraySucursal[1] * 7 + arraySucursal[2] * 3 + arraySucursal[3] * 6) % 11);
    if (digito1Control == 10)
    {
        digito1Control = 1;

    }
    int digito2Control = 11 - ((arrayNumeroCuenta[0] * 1 + arrayNumeroCuenta[1] * 2 + arrayNumeroCuenta[2] * 4 + arrayNumeroCuenta[3] * 8 + arrayNumeroCuenta[4] * 5 + arrayNumeroCuenta[5] * 10 + arrayNumeroCuenta[6] * 9 + arrayNumeroCuenta[7] * 7 + arrayNumeroCuenta[8] * 3 + arrayNumeroCuenta[9] * 6) % 11);

    if (digito2Control == 10)
    {
        digito2Control = 1;
    }

    string digito1ControlString = digito1Control.ToString();
    string digito2ControlString = digito2Control.ToString();
    string digitoControlCalculado = digito1ControlString + digito2ControlString;

    if (digitosControl == digitoControlCalculado)
    {
        Console.WriteLine("Cuenta del banco valida");
        Console.WriteLine("");
        Console.WriteLine("Numeros de la entidad: " + cuentaCompleta[0]);
        Console.WriteLine("");
        Console.WriteLine("Numeros de la sucursal: " + cuentaCompleta[1]);
        Console.WriteLine("");
        Console.WriteLine("Digitos de control: " + cuentaCompleta[2]);
        Console.WriteLine("");
        Console.WriteLine("Numero de cuenta: " + cuentaCompleta[3]);
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Cuenta del banco no valida");

    }


}
else
{
    Console.WriteLine("Numero de cuenta no valido");
}



static int[] PasarAArray(int numeroAConvertir, int tamañoArray)
{
    int[] array = new int[tamañoArray];
    int i = 0;
    do
    {

        
            array[i] = numeroAConvertir % 10;
            numeroAConvertir = numeroAConvertir / 10;
            i++;

        

    } while (numeroAConvertir > 0);

    return array.Reverse().ToArray();
}


static bool Validar(string patron, string palabraAValidar)
{
    bool validar = false;
    Regex regex = new Regex(patron);
    if (regex.IsMatch(palabraAValidar))
    {
        validar = true;
    }
    else
    {
        validar = false;
    }
    return validar;
}

