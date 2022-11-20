// See https://aka.ms/new-console-template for more information

int [] array = new int[10];
Random r = new Random();
int numinicial = -1;
int contador = default;
int contadorfinal= default;
int numMax = default;
for (int i = 0; i<array.Length;i++)
    array[i] = r.Next(0,101);
    foreach (int c in array)
    {
    
        if(numinicial < c)
        {           
            numMax = c;
            contador++;
            numinicial = c;
            contadorfinal = contador;
        }
        else
            contador++;
    }

Console.WriteLine(contadorfinal); 
Console.WriteLine(numMax);
   foreach (int c in array)
   Console.Write(c+" "); 


