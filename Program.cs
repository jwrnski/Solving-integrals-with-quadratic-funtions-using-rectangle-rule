using System;

namespace lab6._22
{
    class Program
    {       
        public static void pole(double xd, double xg, int a, int b, int c)
        {         
            double N = 100000;
            double dx = (xg - xd) / N;
            double fx, suma = 0, k = 0;
            double[] pole = new double[(int)N+1];
            double[] fxi = new double[(int)N+1];
            for(double i = xd; i <= xg; i+=dx)
            {               
                fx = a * i * i + b * i + c;
                fxi[(int)k] = fx;
                k++;
            }
            for (double j = 1; j <= N; j++)
            {
                pole[(int)j] = fxi[(int)j] * dx;
                suma += pole[(int)j];
            }
            Console.WriteLine(suma);
        }       
        //ax^2 + bx + c
        static void Main(string[] args)
        {
            Console.Write("Podaj parametr a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj parametr b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Podaj parametr c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Podaj dolną granicę: ");
            double xd = int.Parse(Console.ReadLine());
            Console.Write("Podaj górną granicę: ");
            double xg = int.Parse(Console.ReadLine());            
            pole(xd, xg, a, b, c);            
           
        }
    }
}
