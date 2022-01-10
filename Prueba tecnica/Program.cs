using System;

namespace Prueba_tecnica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad del producto");
            double cantidad;
            cantidad = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el valor del producto");
            double valor;
            valor = Double.Parse(Console.ReadLine());


            double valorIva = IVA(valor);
            double ValorTotal = ValorT(valor, valorIva, cantidad);
            Console.WriteLine("valor del Iva es : " + valorIva);
            Console.WriteLine("valor del Total es : " + ValorTotal);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("introduzca el tamaño de la matriz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            
            
            int [,]ma = M(n);
       
            Console.WriteLine(ma);




        }

        public static double IVA(double valor)
        {
            double valorIva = (valor * 0.19);

            return valorIva;

        }

        public static double ValorT(double valor, double valorIva, double cantidad)
        {
            double valorTotal = cantidad * (valor + valorIva);

            return valorTotal;

        }

        public static int [,]M (int n)
        {
            int x = 1;
            int a = n;
            int b = n - 1;
            int[,] matriz = new int[n, n];

            for (int fila = 0; fila < n; fila++, a--, b--)
            {
                for (int columna = 0; columna < n; columna++)
                {
                    if (fila == columna)
                    {
                        matriz[fila, columna] = x++;
                        matriz[fila, b] = a;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");


                }
                Console.Write("\n");
            }

            return matriz;
        }

    }
}

