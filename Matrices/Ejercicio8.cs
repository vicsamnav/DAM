
Random generador = new Random();
int nNumeros = 0;
int lineas = 0;
int[][][] m = new int[2][][];

for(int i=0;i<m.Length;i++)
{
    Console.WriteLine("Dime el numero de lineas");
    lineas = int.Parse(Console.ReadLine());
    Array.Resize(ref m[i],lineas);

    for(int j=0;j<m[i].Length;j++)
    {
            Array.Resize(ref m[i][j],nNumeros);
            Console.WriteLine("Dime el numero de numeros");
            nNumeros = int.Parse(Console.ReadLine());
        for(int x=0;x<m[i][j].Length;x++)
        {
            m[i][j][x] = generador.Next(0,10);
            
        }
        
    }
   
}

for(int i=0;i<m.Length;i++)
{

    for(int j=0;j<m[i].Length;j++)
    {
    
        for(int x=0;x<m[i][j].Length;x++)
        {
            Console.Write(m[i][j][x]+" ");
            
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}


