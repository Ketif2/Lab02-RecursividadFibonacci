using System.Diagnostics;
namespace Labo02_RecursivoFibonacci;
class Program
{
    static int FibonacciRecursivo(int n){
        if(n < 2){
            return n;
        }else{
            return FibonacciRecursivo(n-2) + FibonacciRecursivo(n-1);
        }
    }
    static void FibonacciIterativo(int n){
        int i;
        int ant1=1,ant2=1;
        Stopwatch relojI = new Stopwatch();
        relojI.Start();
        Console.Write("0 1 1 ");
        for(i = 1;i < (n-2);i++){
            int a = ant1 + ant2;
            Console.Write(a + " ");
            ant2 = ant1;
            ant1 = a;
        }
        relojI.Stop();
        Console.WriteLine($"Tiempo en Iterativo-> {relojI.Elapsed.TotalMilliseconds} ms");

    }

    static void Main(string[] args)
    {
        Stopwatch relojR = new Stopwatch();
        string recursivo="";
        int n,j;
        do
        {
            Console.WriteLine("Introduzca el número de términos: ");
            n = int.Parse(Console.ReadLine());
        } while (n<=1);
            Console.WriteLine("\tSerie numero de fibonacci recursivo ");
            relojR.Start();
            for(j = 0 ; j<n ; j++){
                recursivo += FibonacciRecursivo(j) + " ";
            }
            relojR.Stop();
            Console.WriteLine(recursivo+"\n");
            Console.WriteLine($"Tiempo en Recursividad -> {relojR.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine("\tSerie numero de fibonacci iterativo ");
            FibonacciIterativo(n);
    }
}