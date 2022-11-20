// See https://aka.ms/new-console-template for more information

//Ejercicio 10 

int[] notas = new int[25];

for(int i = 0; i<notas.Length;i++)
{
int numeroElegir = int.Parse(Console.ReadLine());
if(numeroElegir<0 || numeroElegir>10){
    break;
}else{
    notas[i] = numeroElegir;
}
}

int[] frecuencia = new int[11];
for(int i = 0; i< notas.Length;i++)
{
    frecuencia[notas[i]]= frecuencia[notas[i]]+1;
}



for(int j=0;j<frecuencia.Length;j++)
{
    Console.Write($"{j,-3}");
    
}
Console.WriteLine("");
for(int j=0;j<frecuencia.Length;j++)
{
    
    
    Console.Write($"{frecuencia[j],-3}");
}