// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

int num;

Console.WriteLine("Ingrese un numero: ");
if (int.TryParse(Console.ReadLine(),out num))
{
    int inver=0;
    while (num>0)
    {
        inver=inver*10+num%10;
        num=num/10;
        
    } 
    Console.WriteLine("Numero invertido: "+inver);
    
} else
{
    Console.WriteLine("No es numero");
}