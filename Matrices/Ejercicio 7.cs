// See https://aka.ms/new-console-template for more information




int[,] aforoSalas = new int[3, 3]
{
    {200, 200, 200},
    {150, 150, 150},
    {125, 125, 125}
};
int entradasVendidas;
string salaElegida;
int numSesion;
int eleccion;
do
{

    Console.WriteLine("1-Venta de entradas");
    Console.WriteLine("2-Estadistica de aforo");
    eleccion = int.Parse(Console.ReadLine());
    switch (eleccion)
    {
        case 1:
            Console.WriteLine("¿Cuantas entradas quieres?");
            entradasVendidas = int.Parse(Console.ReadLine());
            Console.WriteLine("Elige una sala: SalaA, SalaB, SalaC");
            salaElegida = Console.ReadLine().ToUpper();
            int numSala = salaElegida switch
            {
                "SALAA" => 0,
                "SALAB" => 1,
                "SALAC" => 2,

            };
            Console.WriteLine("Elige la sesion: 1,2,3");
            numSesion = int.Parse(Console.ReadLine()) - 1;

            if (aforoSalas[numSala, numSesion] <= entradasVendidas)
            {
                Console.WriteLine("No quedan entradas para esa sesion en esa sala");
            }
            else
            {
                aforoSalas[numSala, numSesion] -= entradasVendidas;
            }
            break;
        case 2:
            for (int i = 0; i < aforoSalas.GetLength(0); i++)
            {
                for (int j = 0; j < aforoSalas.GetLength(1); j++)
                {
                    Console.Write(aforoSalas[i, j] + " ");
                }
                Console.WriteLine("");
            }
            break;
    }
Console.WriteLine("Presiona ESC si quieres salir");
} while (Console.ReadKey().Key!= ConsoleKey.Escape);


